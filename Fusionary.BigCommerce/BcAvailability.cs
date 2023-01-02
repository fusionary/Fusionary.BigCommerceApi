namespace Fusionary.BigCommerce;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcAvailability
{
    [JsonPropertyName("available")]
    Available,
    [JsonPropertyName("disabled")]
    Disabled,
    [JsonPropertyName("preorder")]
    Preorder
}