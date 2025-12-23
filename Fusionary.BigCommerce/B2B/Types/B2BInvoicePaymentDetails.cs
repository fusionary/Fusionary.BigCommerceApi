namespace Fusionary.BigCommerce.B2B.Types;

/// <summary>
/// Payment details containing memo and other information.
/// </summary>
public record B2BInvoicePaymentDetails
{
    [JsonPropertyName("memo")]
    public string? Memo { get; init; }
}