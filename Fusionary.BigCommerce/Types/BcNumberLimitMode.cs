namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcNumberLimitMode
{
    [JsonPropertyName("lowest")]
    Lowest,

    [JsonPropertyName("highest")]
    Highest,

    [JsonPropertyName("range")]
    Range
}