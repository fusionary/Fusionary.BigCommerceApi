namespace Fusionary.BigCommerce;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcCondition
{
    [JsonPropertyName("new")]
    New,
    [JsonPropertyName("used")]
    Used,
    [JsonPropertyName("refurbished")]
    Refurbished
}