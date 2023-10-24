namespace DeliArg.WebApi.Dtos;

public class ProductResponseDto : BaseResponseDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string PictureUrl { get; set; } = string.Empty;
}
