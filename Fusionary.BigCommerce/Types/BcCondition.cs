namespace Fusionary.BigCommerce.Types;

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