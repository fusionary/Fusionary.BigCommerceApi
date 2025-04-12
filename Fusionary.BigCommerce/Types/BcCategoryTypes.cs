namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcCategoryTypes
{
    [JsonPropertyName("all")]
    All,

    [JsonPropertyName("specific")]
    Specific,

    [JsonPropertyName("none")]
    None
}