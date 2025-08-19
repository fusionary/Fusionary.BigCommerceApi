namespace Fusionary.BigCommerce.B2B.Types;

public record B2BInvoiceShipment
{
    [JsonPropertyName("addressIndex")]
    public string? AddressIndex { get; init; }
    
    [JsonPropertyName("shipDate")]
    public string? ShipDate { get; init; }
    
    [JsonPropertyName("shipVia")]
    public string? ShipVia { get; init; }
    
    [JsonPropertyName("trackingNumber")]
    public string? TrackingNumber { get; init; }
    
    [JsonPropertyName("comments")]
    public string? Comments { get; init; }
}