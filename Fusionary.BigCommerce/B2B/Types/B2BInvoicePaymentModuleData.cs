namespace Fusionary.BigCommerce.B2B.Types;

/// <summary>
/// Module-specific data for a payment.
/// </summary>
public record B2BInvoicePaymentModuleData
{
    [JsonPropertyName("cartId")]
    public string? CartId { get; init; }

    [JsonPropertyName("orderId")]
    public int? OrderId { get; init; }

    [JsonPropertyName("transactions")]
    public List<B2BInvoicePaymentTransaction>? Transactions { get; init; }
}