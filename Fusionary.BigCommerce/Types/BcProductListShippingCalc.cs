namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcProductListShippingCalc
{
    [JsonPropertyName("none")]
    None,

    [JsonPropertyName("weight")]
    Weight,

    [JsonPropertyName("package")]
    Package
}