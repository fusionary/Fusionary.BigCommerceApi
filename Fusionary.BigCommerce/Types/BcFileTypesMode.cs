namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcFileTypesMode
{
    [JsonPropertyName("specific")]
    Specific,

    [JsonPropertyName("all")]
    All
}