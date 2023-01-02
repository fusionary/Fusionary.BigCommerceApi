namespace Fusionary.BigCommerce;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcBit
{
    [JsonPropertyName("1")]
    On,
    [JsonPropertyName("0")]
    Off
}