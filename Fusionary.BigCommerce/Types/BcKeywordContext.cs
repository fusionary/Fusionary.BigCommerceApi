namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcKeywordContext
{
    [JsonPropertyName("merchant")]
    Merchant,

    [JsonPropertyName("shopper")]
    Shopper
}