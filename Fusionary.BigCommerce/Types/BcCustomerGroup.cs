namespace Fusionary.BigCommerce.Types;

public class BcCustomerGroup : BcCustomerGroupPost
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
}