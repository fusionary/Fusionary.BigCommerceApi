namespace Fusionary.BigCommerce.Types;

public record BcProductFull
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("weight")]
    public double Weight { get; set; }

    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    [JsonPropertyName("type")]
    private BcProductType Type { get; set; } = BcProductType.Physical;
}