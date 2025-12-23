namespace Fusionary.BigCommerce.B2B.Types;

/// <summary>
/// Request to create an offline payment.
/// </summary>
public record B2BInvoicePaymentCreateRequest
{
    [JsonPropertyName("lineItems")]
    public required List<B2BInvoicePaymentCreateLineItem> LineItems { get; init; }

    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    [JsonPropertyName("details")]
    public required B2BInvoicePaymentDetails Details { get; init; }

    [JsonPropertyName("customerId")]
    public required string CustomerId { get; init; }

    [JsonPropertyName("externalId")]
    public string? ExternalId { get; init; }

    [JsonPropertyName("externalCustomerId")]
    public string? ExternalCustomerId { get; init; }

    [JsonPropertyName("payerName")]
    public string? PayerName { get; init; }

    [JsonPropertyName("payerCustomerId")]
    public string? PayerCustomerId { get; init; }

    [JsonPropertyName("processingStatus")]
    public int? ProcessingStatus { get; init; }

    [JsonPropertyName("channelId")]
    public int? ChannelId { get; init; }
}