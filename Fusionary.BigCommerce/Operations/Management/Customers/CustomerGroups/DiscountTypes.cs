namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public enum DiscountTypes
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