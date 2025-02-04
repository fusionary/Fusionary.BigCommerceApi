namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public class BcCustomerGroupPost
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    
    [JsonPropertyName("is_default")]
    public bool? IsDefault { get; set; }
    
    [JsonPropertyName("is_group_for_guests")]
    public bool? IsGroupForGuests { get; set; }
    
    [JsonPropertyName("category_access")]
    public CategoryAccess? CategoryAccess { get; set; }
    
    [JsonPropertyName("discount_rules")]
    public List<DiscountRules>? DiscountRules { get; set; }
}