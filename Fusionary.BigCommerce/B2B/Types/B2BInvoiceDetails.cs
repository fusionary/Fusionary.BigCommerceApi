namespace Fusionary.BigCommerce.B2B.Types;

public record B2BInvoiceDetails
{
    [JsonPropertyName("type")]
    public string? Type  { get; init; }
    
    [JsonPropertyName("header")]
    public B2BInvoiceDetailsHeader? Header { get; init; }
}