namespace Fusionary.BigCommerce.Types;

public class BcCustomerGroupPost
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("is_default")]
    public bool? IsDefault { get; set; }

    [JsonPropertyName("is_group_for_guests")]
    public bool? IsGroupForGuests { get; set; }

    [JsonPropertyName("category_access")]
    public BcCategoryAccess? CategoryAccess { get; set; }

    [JsonPropertyName("discount_rules")]
    public List<BcDiscountRules>? DiscountRules { get; set; }
}