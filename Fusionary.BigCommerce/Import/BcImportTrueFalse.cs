namespace Fusionary.BigCommerce.Import;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcImportTrueFalse
{
    [JsonPropertyName("TRUE")]
    True,

    [JsonPropertyName("FALSE")]
    False
}