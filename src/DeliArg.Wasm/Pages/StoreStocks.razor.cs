using DeliArg.Wasm.Dtos;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace DeliArg.Wasm.Pages;

public partial class StoreStocks
{
    [Inject]
    private HttpClient Http { get; set; } = default!;

    private IQueryable<StoreStockResponseDto>? storeStocks { get; set; }

    protected override async Task OnInitializedAsync()
    {
        storeStocks = (await Http.GetFromJsonAsync<List<StoreStockResponseDto>>("api/storestocks"))!.AsQueryable();
    }
}
