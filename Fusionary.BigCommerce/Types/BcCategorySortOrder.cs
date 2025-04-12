namespace Fusionary.BigCommerce.Types;

public record BcCategorySortOrder
{
    [JsonPropertyName("product_id")]
    public int ProductId { get; set; }

    [JsonPropertyName("sort_order")]
    public int SortOrder { get; set; }
}