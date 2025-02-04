namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public class CategoryAccess
{
    [JsonPropertyName("categories")]
    public List<int>? CategoryIds { get; set; }

    [JsonPropertyName("type")] public CategoryTypes? Type { get; set; }
}