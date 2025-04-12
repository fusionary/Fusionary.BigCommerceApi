namespace Fusionary.BigCommerce.Types;

public record BcCategoryAccess
{
    [JsonPropertyName("categories")]
    public List<int>? CategoryIds { get; set; }

    [JsonPropertyName("type")]
    public BcCategoryTypes? Type { get; set; }
}