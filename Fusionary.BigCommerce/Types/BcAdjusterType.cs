namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum BcAdjusterType
{
    [JsonPropertyName("relative")]
    Relative,

    [JsonPropertyName("percentage")]
    Percentage
}