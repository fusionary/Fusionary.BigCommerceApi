namespace Fusionary.BigCommerce.B2B.Types;

/// <summary>
/// Response from creating an offline payment.
/// </summary>
public record B2BInvoicePaymentCreateResponse
{
    [JsonPropertyName("paymentId")]
    public int PaymentId { get; init; }
}