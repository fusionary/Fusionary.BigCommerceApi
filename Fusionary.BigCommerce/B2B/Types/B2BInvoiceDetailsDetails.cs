namespace Fusionary.BigCommerce.B2B.Types;

public record B2BInvoiceDetailsDetails
{
    [JsonPropertyName("shipments")]
    public List<B2BInvoiceShipment>? Shipments { get; init; }
    
    [JsonPropertyName("lineItems")]
    public List<B2BInvoiceLineItem>? LineItems { get; init; }
}