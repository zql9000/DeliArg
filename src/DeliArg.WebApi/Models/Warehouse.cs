namespace DeliArg.WebApi.Models;

public class Warehouse : Base
{
    public required string Name { get; set; }
    public string Address { get; set; } = string.Empty;
}
