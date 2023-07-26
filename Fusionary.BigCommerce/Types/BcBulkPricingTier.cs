namespace Fusionary.BigCommerce.Types;

public record BcBulkPricingTier
{
    [JsonPropertyName("quantity_min")]
    public int? QuantityMin { get; set; }

    [JsonPropertyName("quantity_max")]
    public int? QuantityMax { get; set; }

    [JsonPropertyName("type")]
    public BcBulkPricingTierType Type { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }
}