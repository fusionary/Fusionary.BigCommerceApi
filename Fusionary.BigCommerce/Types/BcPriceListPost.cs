namespace Fusionary.BigCommerce.Types;

public record BcPriceListPost : BcExtensionData
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("active")]
    public bool Active { get; set; }
}