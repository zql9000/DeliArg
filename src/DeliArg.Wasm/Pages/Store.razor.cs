using DeliArg.Wasm.Dtos;
using Microsoft.AspNetCore.Components;
using Microsoft.Fast.Components.FluentUI;
using System.Net;
using System.Net.Http.Json;

namespace DeliArg.Wasm.Pages;

public partial class Store
{
    [Inject]
    private HttpClient Http { get; set; } = default!;
    [Inject]
    private IToastService ToastService { get; set; } = default!;
    [Inject]
    private NavigationManager NavManager { get; set; } = default!;
    [Parameter]
    public int StoreId { get; set; }

    private StoreResponseDto store { get; set; } = new();
    private bool editing { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (StoreId == 0)
        {
            editing = true;
        }
        else
        {
            store = await Http.GetFromJsonAsync<StoreResponseDto>($"api/stores/{StoreId}") ?? new();
        }
    }

    private async Task Create()
    {
        var result = await Http.PostAsJsonAsync("api/stores", store);

        if (result == null || result.StatusCode != HttpStatusCode.Created)
        {
            ToastService.ShowError("Error creating Store.");
            return;
        }

        NavManager.NavigateTo("/Stores");
        ToastService.ShowSuccess("Store created.");
    }

    private async Task Update()
    {
        var result = await Http.PutAsJsonAsync($"api/stores/{StoreId}", store);

        if (result == null || result.StatusCode != HttpStatusCode.NoContent)
        {
            ToastService.ShowError("Error updating Store.");
            return;
        }

        NavManager.NavigateTo("/Stores");
        ToastService.ShowSuccess("Store updated.");
    }

    private async Task CancelUpdate()
    {
        store = await Http.GetFromJsonAsync<StoreResponseDto>($"api/stores/{StoreId}") ?? new();
        editing = false;
    }

    private async Task Delete()
    {
        var result = await Http.DeleteAsync($"api/stores/{StoreId}");

        if (result == null || result.StatusCode != HttpStatusCode.OK)
        {
            ToastService.ShowError("Error deleting Store.");
            return;
        }

        NavManager.NavigateTo("/Stores");
        ToastService.ShowSuccess("Store deleted.");
    }
}
