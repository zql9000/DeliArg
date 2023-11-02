namespace DeliArg.Wasm.Dtos;

public class StoreRequestDto : BaseRequestDto
{
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
}
