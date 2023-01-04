namespace Fusionary.BigCommerce.Types;

public enum BcResourceType
{
    [JsonPropertyName("order")]
    Order,
    [JsonPropertyName("brand")]
    Brand,
    [JsonPropertyName("product")]
    Product,
    [JsonPropertyName("variant")]
    Variant,
    [JsonPropertyName("category")]
    Category
}