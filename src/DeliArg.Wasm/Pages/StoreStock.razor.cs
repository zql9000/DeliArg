using DeliArg.Wasm.Dtos;
using DeliArg.Wasm.Mapping;
using Microsoft.AspNetCore.Components;
using Microsoft.Fast.Components.FluentUI;
using System.Net;
using System.Net.Http.Json;

namespace DeliArg.Wasm.Pages;

public partial class StoreStock
{
    [Inject]
    private HttpClient Http { get; set; } = default!;
    [Inject]
    private IToastService ToastService { get; set; } = default!;
    [Inject]
    private NavigationManager NavManager { get; set; } = default!;
    [Parameter]
    public int StoreStockId { get; set; }

    private StoreStockResponseDto storeStock { get; set; } = new();
    private bool editing { get; set; }
    private List<ProductResponseDto> products { get; set; } = null!;
    private List<StoreResponseDto> stores { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        products = await Http.GetFromJsonAsync<List<ProductResponseDto>>($"api/products") ?? new();
        stores = await Http.GetFromJsonAsync<List<StoreResponseDto>>($"api/stores") ?? new();

        if (StoreStockId == 0)
        {
            editing = true;
            products.Insert(0, new ProductResponseDto { Id = -1, Name = "Select a product" });
            stores.Insert(0, new StoreResponseDto { Id = -1, Name = "Select a store" });
        }
        else
        {
            storeStock = await Http.GetFromJsonAsync<StoreStockResponseDto>($"api/storeStocks/{StoreStockId}") ?? new();
        }
    }

    private async Task Create()
    {
        if (!ValidateData()) return;

        StoreStockRequestDto newStoreStock = storeStock.ToRequest();

        var result = await Http.PostAsJsonAsync("api/storeStocks", newStoreStock);

        if (result == null || result.StatusCode != HttpStatusCode.Created)
        {
            ToastService.ShowError("Error creating StoreStock.");
            return;
        }

        NavManager.NavigateTo("/StoreStocks");
        ToastService.ShowSuccess("Store Stock created.");
    }

    private bool ValidateData()
    {
        if (storeStock.Product is null || storeStock.Product.Id == -1)
        {
            ToastService.ShowError("Product selected is invalid.");
            return false;
        }

        if (storeStock.Store is null || storeStock.Store.Id == -1)
        {
            ToastService.ShowError("Store selected is invalid.");
            return false;
        }

        return true;
    }

    private async Task Update()
    {
        StoreStockRequestDto modifyStoreStock = storeStock.ToRequest();

        var result = await Http.PutAsJsonAsync($"api/storeStocks/{StoreStockId}", modifyStoreStock);

        if (result == null || result.StatusCode != HttpStatusCode.NoContent)
        {
            ToastService.ShowError("Error updating StoreStock.");
            return;
        }

        NavManager.NavigateTo("/StoreStocks");
        ToastService.ShowSuccess("Store Stock updated.");
    }

    private async Task CancelUpdate()
    {
        storeStock = await Http.GetFromJsonAsync<StoreStockResponseDto>($"api/storeStocks/{StoreStockId}") ?? new();
        editing = false;
    }

    private async Task Delete()
    {
        var result = await Http.DeleteAsync($"api/storeStocks/{StoreStockId}");

        if (result == null || result.StatusCode != HttpStatusCode.OK)
        {
            ToastService.ShowError("Error deleting StoreStock.");
            return;
        }

        NavManager.NavigateTo("/StoreStocks");
        ToastService.ShowSuccess("Store Stock deleted.");
    }
}
