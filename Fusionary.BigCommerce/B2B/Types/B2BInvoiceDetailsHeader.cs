namespace Fusionary.BigCommerce.B2B.Types;

public class B2BInvoiceDetailsHeader
{
    [JsonPropertyName("orderDate")]
    public int? OrderDate { get; init; }
    
    [JsonPropertyName("costLines")]
    public List<B2BInvoiceDetailsHeaderCostLine>? CostLines { get; init; }
    
    [JsonPropertyName("billingAddress")]
    public B2BInvoiceAddress? BillingAddress { get; init; }
    
    [JsonPropertyName("shippingAddresses")]
    public List<B2BInvoiceAddress>? ShippingAddresses { get; init; }
}