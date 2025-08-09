namespace Fusionary.BigCommerce.B2B.Types;

public class B2BOrderExtraInfo
{
    [JsonPropertyName("billingAddressId")]
    public int? BillingAddressId { get; set; }
    
    [JsonPropertyName("shippingAddressId")]
    public int? ShippingAddressId { get; set; }
}