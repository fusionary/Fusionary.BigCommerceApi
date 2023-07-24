namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcDateLimitMode
{
    [JsonPropertyName("earliest")]
    Earliest,
    
    [JsonPropertyName("range")]
    Range,
    
    [JsonPropertyName("latest")]
    Latest
}