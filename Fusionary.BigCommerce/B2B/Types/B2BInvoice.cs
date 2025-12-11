namespace Fusionary.BigCommerce.B2B.Types;

public record B2BInvoice
{
    [JsonPropertyName("id")]
    public BcId? Id { get; init; }
    [JsonPropertyName("customerId")]
    public string? CustomerId { get; init; }
    [JsonPropertyName("externalCustomerId")]
    public string? ExternalCustomerId { get; init; }
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; init; }
    [JsonPropertyName("invoiceNumber")]
    public string? InvoiceNumber { get; init; }
    [JsonPropertyName("type")]
    public string? Type { get; init; }
    [JsonPropertyName("dueDate")]
    public int? DueDateTimestamp { get; init; }
    [JsonPropertyName("status")]
    public int? Status { get; init; }
    [JsonPropertyName("orderNumber")]
    public int? OrderNumber { get; init; }
    [JsonPropertyName("purchaseOrderNumber")]
    public string? PONumber { get; init; }
    [JsonPropertyName("isPendingPayment")]
    public int? IsPendingPayment { get; init; }
    [JsonPropertyName("source")]
    public int? Source { get; init; }
    [JsonPropertyName("customerName")]
    public string? CustomerName { get; init; }
    [JsonPropertyName("createdAt")]
    public BcDate? CreatedAt { get; init; }
    [JsonPropertyName("updatedAt")]
    public BcDate? UpdatedAt { get; init; }
    [JsonPropertyName("channelId")]
    public string? ChannelId { get; init; }
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; init; }
    [JsonPropertyName("termsConditions")]
    public string? TermsAndConditions { get; init; }
    [JsonPropertyName("extraFields")]
    public List<B2BOrderExtraField>? ExtraFields { get; init; }
    [JsonPropertyName("originalBalance")]
    public B2BMoneyAmount? originalBalance { get; init; }
    [JsonPropertyName("openBalance")]
    public B2BMoneyAmount? openBalance { get; init; }
    [JsonPropertyName("details")]
    public B2BInvoiceDetails? Details { get; init; }
    
    /// <summary>
    /// Only used for create/update.
    /// </summary>
    [JsonPropertyName("externalPdfUrl")]
    public string? ExternalPdfUrl { get; init; }
}