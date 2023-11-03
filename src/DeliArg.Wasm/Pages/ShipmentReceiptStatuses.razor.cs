using DeliArg.Wasm.Dtos;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace DeliArg.Wasm.Pages;

public partial class ShipmentReceiptStatuses
{
    [Inject]
    private HttpClient Http { get; set; } = default!;

    private IQueryable<ShipmentReceiptStatusResponseDto>? shipmentReceiptStatuses { get; set; }

    protected override async Task OnInitializedAsync()
    {
        shipmentReceiptStatuses = (await Http.GetFromJsonAsync<List<ShipmentReceiptStatusResponseDto>>("api/shipmentReceiptStatuses"))!.AsQueryable();
    }
}
