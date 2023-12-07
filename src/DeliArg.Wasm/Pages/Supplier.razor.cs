using DeliArg.Wasm.Dtos;
using DeliArg.Wasm.Mapping;
using Microsoft.AspNetCore.Components;
using Microsoft.Fast.Components.FluentUI;
using System.Net;
using System.Net.Http.Json;

namespace DeliArg.Wasm.Pages;

public partial class Supplier
{
    [Inject]
    private HttpClient Http { get; set; } = default!;
    [Inject]
    private IToastService ToastService { get; set; } = default!;
    [Inject]
    private NavigationManager NavManager { get; set; } = default!;
    [Parameter]
    public int SupplierId { get; set; }

    private SupplierResponseDto supplier { get; set; } = new();
    private bool editing { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (SupplierId == 0)
        {
            editing = true;
        }
        else
        {
            supplier = await Http.GetFromJsonAsync<SupplierResponseDto>($"api/suppliers/{SupplierId}") ?? new();
        }
    }

    private async Task Create()
    {
        SupplierRequestDto newSupplier = supplier.ToRequest();

        var result = await Http.PostAsJsonAsync("api/suppliers", newSupplier);

        if (result == null || result.StatusCode != HttpStatusCode.Created)
        {
            ToastService.ShowError("Error creating Supplier.");
            return;
        }

        NavManager.NavigateTo("/Suppliers");
        ToastService.ShowSuccess("Supplier created.");
    }

    private async Task Update()
    {
        SupplierRequestDto modifySupplier = supplier.ToRequest();

        var result = await Http.PutAsJsonAsync($"api/suppliers/{SupplierId}", modifySupplier);

        if (result == null || result.StatusCode != HttpStatusCode.NoContent)
        {
            ToastService.ShowError("Error updating Supplier.");
            return;
        }

        NavManager.NavigateTo("/Suppliers");
        ToastService.ShowSuccess("Supplier updated.");
    }

    private async Task CancelUpdate()
    {
        supplier = await Http.GetFromJsonAsync<SupplierResponseDto>($"api/suppliers/{SupplierId}") ?? new();
        editing = false;
    }

    private async Task Delete()
    {
        var result = await Http.DeleteAsync($"api/suppliers/{SupplierId}");

        if (result == null || result.StatusCode != HttpStatusCode.OK)
        {
            ToastService.ShowError("Error deleting Supplier.");
            return;
        }

        NavManager.NavigateTo("/Suppliers");
        ToastService.ShowSuccess("Supplier deleted.");
    }
}
