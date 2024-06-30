namespace Fusionary.BigCommerce.Types;

public enum BcBulkPricingTierType
{
    [JsonPropertyName("fixed")]
    Fixed,

    [JsonPropertyName("price")]
    Price,

    [JsonPropertyName("percent")]
    Percent
}