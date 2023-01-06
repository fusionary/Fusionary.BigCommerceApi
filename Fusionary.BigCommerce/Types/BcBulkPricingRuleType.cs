namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum BcBulkPricingRuleType
{
    /// <summary>
    /// The adjustment amount per product
    /// </summary>
    [JsonPropertyName("price")]
    Price,

    /// <summary>
    /// The adjustment as a percentage of the original price
    /// </summary>
    [JsonPropertyName("percent")]
    Percent,

    /// <summary>
    /// The adjusted absolute price of the product.
    /// </summary>
    [JsonPropertyName("fixed")]
    Fixed
}