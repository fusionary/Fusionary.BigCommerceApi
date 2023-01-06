namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcDiscountTarget
{
    [JsonPropertyName("order")]
    Order,

    [JsonPropertyName("product")]
    Product
}