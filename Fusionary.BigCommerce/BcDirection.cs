namespace Fusionary.BigCommerce;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcDirection
{
    [JsonPropertyName("asc")]
    Asc,
    [JsonPropertyName("desc")]
    Desc
}