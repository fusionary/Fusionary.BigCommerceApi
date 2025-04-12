namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public enum CategoryTypes
{
    [JsonPropertyName("all")]
    All,

    [JsonPropertyName("specific")]
    Specific,

    [JsonPropertyName("none")]
    None
}