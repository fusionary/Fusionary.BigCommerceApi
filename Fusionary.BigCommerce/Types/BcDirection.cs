namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcDirection
{
    [JsonPropertyName("asc")]
    Asc,

    [JsonPropertyName("desc")]
    Desc
}