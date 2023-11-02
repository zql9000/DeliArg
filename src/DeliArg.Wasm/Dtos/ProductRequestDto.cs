namespace DeliArg.Wasm.Dtos;

public class ProductRequestDto : BaseRequestDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string PictureUrl { get; set; } = string.Empty;
}
