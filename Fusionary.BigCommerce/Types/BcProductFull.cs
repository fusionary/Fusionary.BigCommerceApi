namespace Fusionary.BigCommerce.Types;

public class BcProductFull
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("type")]
    private BcProductType Type { get; set; } = BcProductType.Physical;
    
    [JsonPropertyName("weight")]
    public double Weight { get; set; }

    [JsonPropertyName("price")]
    public decimal Price { get; set; }
}