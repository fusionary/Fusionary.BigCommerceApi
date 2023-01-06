namespace Fusionary.BigCommerce.Types;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
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