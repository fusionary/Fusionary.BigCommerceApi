namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcInventoryTracking
{
    [JsonPropertyName("none")]
    None,

    [JsonPropertyName("product")]
    Product,

    [JsonPropertyName("variant")]
    Variant
}