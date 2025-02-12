namespace Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

public class BcCustomerGroup : BcCustomerGroupPost
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
}