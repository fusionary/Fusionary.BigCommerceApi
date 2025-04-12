namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public enum DiscountRulesMethods
{
    [JsonPropertyName("fixed")]
    Fixed,

    [JsonPropertyName("percent")]
    Percentage,

    [JsonPropertyName("price")]
    Price
}