using DeliArg.Wasm.Dtos;
using Microsoft.AspNetCore.Components;
using Microsoft.Fast.Components.FluentUI;
using System.Net;
using System.Net.Http.Json;

namespace DeliArg.Wasm.Pages;

public partial class OrderStatus
{
    [Inject]
    private HttpClient Http { get; set; } = default!;
    [Inject]
    private IToastService ToastService { get; set; } = default!;
    [Inject]
    private NavigationManager NavManager { get; set; } = default!;
    [Parameter]
    public int OrderStatusId { get; set; }

    private OrderStatusResponseDto orderStatus { get; set; } = new();
    private bool editing { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (OrderStatusId == 0)
        {
            editing = true;
        }
        else
        {
            orderStatus = await Http.GetFromJsonAsync<OrderStatusResponseDto>($"api/orderStatuses/{OrderStatusId}") ?? new();
        }
    }

    private async Task Create()
    {
        var result = await Http.PostAsJsonAsync("api/orderStatuses", orderStatus);

        if (result == null || result.StatusCode != HttpStatusCode.Created)
        {
            ToastService.ShowError("Error creating orderStatus.");
            return;
        }

        NavManager.NavigateTo("/OrderStatuses");
        ToastService.ShowSuccess("OrderStatus created.");
    }

    private async Task Update()
    {
        var result = await Http.PutAsJsonAsync($"api/orderStatuses/{OrderStatusId}", orderStatus);

        if (result == null || result.StatusCode != HttpStatusCode.NoContent)
        {
            ToastService.ShowError("Error updating orderStatus.");
            return;
        }

        NavManager.NavigateTo("/OrderStatuses");
        ToastService.ShowSuccess("OrderStatus updated.");
    }

    private async Task CancelUpdate()
    {
        orderStatus = await Http.GetFromJsonAsync<OrderStatusResponseDto>($"api/orderStatuses/{OrderStatusId}") ?? new();
        editing = false;
    }

    private async Task Delete()
    {
        var result = await Http.DeleteAsync($"api/orderStatuses/{OrderStatusId}");

        if (result == null || result.StatusCode != HttpStatusCode.OK)
        {
            ToastService.ShowError("Error deleting orderStatus.");
            return;
        }

        NavManager.NavigateTo("/OrderStatuses");
        ToastService.ShowSuccess("OrderStatus deleted.");
    }
}
