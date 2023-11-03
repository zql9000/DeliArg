using DeliArg.Wasm.Dtos;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace DeliArg.Wasm.Pages;

public partial class OrderStatuses
{
    [Inject]
    private HttpClient Http { get; set; } = default!;

    private IQueryable<OrderStatusResponseDto>? orderStatuses { get; set; }

    protected override async Task OnInitializedAsync()
    {
        orderStatuses = (await Http.GetFromJsonAsync<List<OrderStatusResponseDto>>("api/orderStatuses"))!.AsQueryable();
    }
}
