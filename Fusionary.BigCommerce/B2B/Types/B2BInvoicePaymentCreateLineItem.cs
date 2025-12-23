namespace Fusionary.BigCommerce.B2B.Types;

/// <summary>
/// Line item for creating an offline payment.
/// </summary>
public record B2BInvoicePaymentCreateLineItem
{
    [JsonPropertyName("invoiceId")]
    public required BcId InvoiceId { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }
}