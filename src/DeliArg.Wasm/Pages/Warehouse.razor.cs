using DeliArg.Wasm.Dtos;
using DeliArg.Wasm.Mapping;
using Microsoft.AspNetCore.Components;
using Microsoft.Fast.Components.FluentUI;
using System.Net;
using System.Net.Http.Json;

namespace DeliArg.Wasm.Pages;

public partial class Warehouse
{
    [Inject]
    private HttpClient Http { get; set; } = default!;
    [Inject]
    private IToastService ToastService { get; set; } = default!;
    [Inject]
    private NavigationManager NavManager { get; set; } = default!;
    [Parameter]
    public int WarehouseId { get; set; }

    private WarehouseResponseDto warehouse { get; set; } = new();
    private bool editing { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (WarehouseId == 0)
        {
            editing = true;
        }
        else
        {
            warehouse = await Http.GetFromJsonAsync<WarehouseResponseDto>($"api/warehouses/{WarehouseId}") ?? new();
        }
    }

    private async Task Create()
    {
        WarehouseRequestDto newWarehouse = warehouse.ToRequest();

        var result = await Http.PostAsJsonAsync("api/warehouses", newWarehouse);

        if (result == null || result.StatusCode != HttpStatusCode.Created)
        {
            ToastService.ShowError("Error creating Warehouse.");
            return;
        }

        NavManager.NavigateTo("/Warehouses");
        ToastService.ShowSuccess("Warehouse created.");
    }

    private async Task Update()
    {
        WarehouseRequestDto modifyWarehouse = warehouse.ToRequest();

        var result = await Http.PutAsJsonAsync($"api/warehouses/{WarehouseId}", modifyWarehouse);

        if (result == null || result.StatusCode != HttpStatusCode.NoContent)
        {
            ToastService.ShowError("Error updating Warehouse.");
            return;
        }

        NavManager.NavigateTo("/Warehouses");
        ToastService.ShowSuccess("Warehouse updated.");
    }

    private async Task CancelUpdate()
    {
        warehouse = await Http.GetFromJsonAsync<WarehouseResponseDto>($"api/warehouses/{WarehouseId}") ?? new();
        editing = false;
    }

    private async Task Delete()
    {
        var result = await Http.DeleteAsync($"api/warehouses/{WarehouseId}");

        if (result == null || result.StatusCode != HttpStatusCode.OK)
        {
            ToastService.ShowError("Error deleting Warehouse.");
            return;
        }

        NavManager.NavigateTo("/Warehouses");
        ToastService.ShowSuccess("Warehouse deleted.");
    }
}
