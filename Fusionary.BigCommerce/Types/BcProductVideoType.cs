namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum BcProductVideoType
{
    [JsonPropertyName("youtube")]
    Youtube
}