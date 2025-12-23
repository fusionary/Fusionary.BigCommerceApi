namespace Fusionary.BigCommerce.B2B.Types;

/// <summary>
/// Request to update payment processing status.
/// </summary>
public record B2BInvoicePaymentStatusUpdate
{
    [JsonPropertyName("processingStatus")]
    public int ProcessingStatus { get; init; }
}