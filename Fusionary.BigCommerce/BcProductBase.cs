using JetBrains.Annotations;

namespace Fusionary.BigCommerce;

/// <summary>
/// Required fields to create a new product
/// </summary>
[UsedImplicitly]
public class BcProductBase : BcObject
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("type")]
    public BcProductType Type { get; set; } = BcProductType.Physical;

    [JsonPropertyName("weight")]
    public double Weight { get; set; }

    [JsonPropertyName("price")]
    public decimal Price { get; set; }
}