namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BcDiscountTypes
{
    [JsonPropertyName("price_list")]
    PriceList,

    [JsonPropertyName("category")]
    Category,

    [JsonPropertyName("product")]
    Product,

    [JsonPropertyName("all")]
    SiteWide
}