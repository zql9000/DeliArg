using DeliArg.Wasm.Dtos;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace DeliArg.Wasm.Pages;

public partial class Suppliers
{
    [Inject]
    private HttpClient Http { get; set; } = default!;

    private IQueryable<SupplierResponseDto>? suppliers { get; set; }

    protected override async Task OnInitializedAsync()
    {
        suppliers = (await Http.GetFromJsonAsync<List<SupplierResponseDto>>("api/suppliers"))!.AsQueryable();
    }
}
