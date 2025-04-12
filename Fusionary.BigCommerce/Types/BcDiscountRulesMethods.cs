namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcDiscountRulesMethods
{
    [JsonPropertyName("fixed")]
    Fixed,

    [JsonPropertyName("percent")]
    Percentage,

    [JsonPropertyName("price")]
    Price
}