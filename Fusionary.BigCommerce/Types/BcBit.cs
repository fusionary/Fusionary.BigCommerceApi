namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcBit
{
    [JsonPropertyName("1")]
    On,

    [JsonPropertyName("0")]
    Off
}