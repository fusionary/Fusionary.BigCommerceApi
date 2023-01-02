namespace Fusionary.BigCommerce;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcKeywordContext
{
    [JsonPropertyName("merchant")]
    Merchant,
    [JsonPropertyName("shopper")]
    Shopper
}