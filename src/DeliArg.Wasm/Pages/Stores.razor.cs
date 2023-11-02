using DeliArg.Wasm.Dtos;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace DeliArg.Wasm.Pages;

public partial class Stores
{
    [Inject]
    private HttpClient Http { get; set; } = default!;

    private IQueryable<StoreResponseDto>? stores { get; set; }

    protected override async Task OnInitializedAsync()
    {
        stores = (await Http.GetFromJsonAsync<List<StoreResponseDto>>("api/stores"))!.AsQueryable();
    }
}
