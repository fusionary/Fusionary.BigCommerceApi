namespace Fusionary.BigCommerce;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcProductType
{
    [JsonPropertyName("physical")]
    Physical,
    [JsonPropertyName("digital")]
    Digital
}