namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcProductType
{
    [JsonPropertyName("physical")]
    Physical,
    [JsonPropertyName("digital")]
    Digital
}