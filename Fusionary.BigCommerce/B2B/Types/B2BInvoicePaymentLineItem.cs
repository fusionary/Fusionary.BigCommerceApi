namespace Fusionary.BigCommerce.B2B.Types;

/// <summary>
/// Line item for a payment, linking payment to invoice.
/// </summary>
public record B2BInvoicePaymentLineItem
{
    [JsonPropertyName("paymentId")]
    public BcId? PaymentId { get; init; }

    [JsonPropertyName("invoiceId")]
    public BcId? InvoiceId { get; init; }

    [JsonPropertyName("invoiceNumber")]
    public string? InvoiceNumber { get; init; }

    [JsonPropertyName("amount")]
    public B2BMoneyAmount? Amount { get; init; }
}