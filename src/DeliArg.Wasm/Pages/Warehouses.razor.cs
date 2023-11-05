using DeliArg.Wasm.Dtos;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace DeliArg.Wasm.Pages;

public partial class Warehouses
{
    [Inject]
    private HttpClient Http { get; set; } = default!;

    private IQueryable<WarehouseResponseDto>? warehouses { get; set; }

    protected override async Task OnInitializedAsync()
    {
        warehouses = (await Http.GetFromJsonAsync<List<WarehouseResponseDto>>("api/warehouses"))!.AsQueryable();
    }
}
