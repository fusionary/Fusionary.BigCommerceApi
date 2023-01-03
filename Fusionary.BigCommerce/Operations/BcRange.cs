namespace Fusionary.BigCommerce.Operations;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcRange
{
    [JsonPropertyName("")]
    None,
    [JsonPropertyName(":min")]
    Min,
    [JsonPropertyName(":max")]
    Max
}