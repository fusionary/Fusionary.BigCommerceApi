namespace Fusionary.BigCommerce.Operations;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcModifier
{
    [JsonPropertyName("")]
    None,
    [JsonPropertyName(":in")]
    In,
    [JsonPropertyName(":not_in")]
    NotIn,
    [JsonPropertyName(":min")]
    Min,
    [JsonPropertyName(":max")]
    Max,
    [JsonPropertyName(":greater")]
    GreaterThan,
    [JsonPropertyName(":less")]
    LessThan,
}