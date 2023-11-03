using DeliArg.Wasm.Dtos;
using Microsoft.AspNetCore.Components;
using Microsoft.Fast.Components.FluentUI;
using System.Net;
using System.Net.Http.Json;

namespace DeliArg.Wasm.Pages;

public partial class ShipmentReceiptStatus
{
    [Inject]
    private HttpClient Http { get; set; } = default!;
    [Inject]
    private IToastService ToastService { get; set; } = default!;
    [Inject]
    private NavigationManager NavManager { get; set; } = default!;
    [Parameter]
    public int ShipmentReceiptStatusId { get; set; }

    private ShipmentReceiptStatusResponseDto shipmentReceiptStatus { get; set; } = new();
    private bool editing { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (ShipmentReceiptStatusId == 0)
        {
            editing = true;
        }
        else
        {
            shipmentReceiptStatus = await Http.GetFromJsonAsync<ShipmentReceiptStatusResponseDto>($"api/shipmentReceiptStatuses/{ShipmentReceiptStatusId}") ?? new();
        }
    }

    private async Task Create()
    {
        var result = await Http.PostAsJsonAsync("api/shipmentReceiptStatuses", shipmentReceiptStatus);

        if (result == null || result.StatusCode != HttpStatusCode.Created)
        {
            ToastService.ShowError("Error creating Shipment Receipt Status.");
            return;
        }

        NavManager.NavigateTo("/ShipmentReceiptStatuses");
        ToastService.ShowSuccess("Shipment Receipt Status created.");
    }

    private async Task Update()
    {
        var result = await Http.PutAsJsonAsync($"api/shipmentReceiptStatuses/{ShipmentReceiptStatusId}", shipmentReceiptStatus);

        if (result == null || result.StatusCode != HttpStatusCode.NoContent)
        {
            ToastService.ShowError("Error updating Shipment Receipt Status.");
            return;
        }

        NavManager.NavigateTo("/ShipmentReceiptStatuses");
        ToastService.ShowSuccess("Shipment Receipt Status updated.");
    }

    private async Task CancelUpdate()
    {
        shipmentReceiptStatus = await Http.GetFromJsonAsync<ShipmentReceiptStatusResponseDto>($"api/shipmentReceiptStatuses/{ShipmentReceiptStatusId}") ?? new();
        editing = false;
    }

    private async Task Delete()
    {
        var result = await Http.DeleteAsync($"api/shipmentReceiptStatuses/{ShipmentReceiptStatusId}");

        if (result == null || result.StatusCode != HttpStatusCode.OK)
        {
            ToastService.ShowError("Error deleting Shipment Receipt Status.");
            return;
        }

        NavManager.NavigateTo("/ShipmentReceiptStatuses");
        ToastService.ShowSuccess("Shipment Receipt Status deleted.");
    }
}
