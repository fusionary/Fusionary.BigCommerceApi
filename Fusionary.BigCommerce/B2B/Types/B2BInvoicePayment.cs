using Fusionary.BigCommerce.Types;

namespace Fusionary.BigCommerce.B2B.Types;

/// <summary>
/// Represents a payment in the B2B Invoice Management system.
/// </summary>
public record B2BInvoicePayment
{
    [JsonPropertyName("id")]
    public BcId? Id { get; init; }

    [JsonPropertyName("createdAt")]
    public BcTimestamp? CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public BcTimestamp? UpdatedAt { get; init; }

    [JsonPropertyName("storeHash")]
    public string? StoreHash { get; init; }

    [JsonPropertyName("customerId")]
    public string? CustomerId { get; init; }

    [JsonPropertyName("externalId")]
    public string? ExternalId { get; init; }

    [JsonPropertyName("externalCustomerId")]
    public string? ExternalCustomerId { get; init; }

    [JsonPropertyName("payerName")]
    public string? PayerName { get; init; }

    [JsonPropertyName("payerCustomerId")]
    public string? PayerCustomerId { get; init; }

    [JsonPropertyName("details")]
    public B2BInvoicePaymentDetails? Details { get; init; }

    [JsonPropertyName("moduleName")]
    public string? ModuleName { get; init; }

    [JsonPropertyName("fees")]
    public List<decimal>? Fees { get; init; }

    [JsonPropertyName("moduleData")]
    public B2BInvoicePaymentModuleData? ModuleData { get; init; }

    [JsonPropertyName("processingStatus")]
    public int? ProcessingStatus { get; init; }

    [JsonPropertyName("appliedStatus")]
    public int? AppliedStatus { get; init; }

    [JsonPropertyName("fundingStatus")]
    public int? FundingStatus { get; init; }

    [JsonPropertyName("total")]
    public B2BMoneyAmount? Total { get; init; }

    [JsonPropertyName("lineItems")]
    public List<B2BInvoicePaymentLineItem>? LineItems { get; init; }

    [JsonPropertyName("customerName")]
    public string? CustomerName { get; init; }

    [JsonPropertyName("customerBcId")]
    public int? CustomerBcId { get; init; }

    [JsonPropertyName("customerBcGroupName")]
    public string? CustomerBcGroupName { get; init; }

    [JsonPropertyName("bcId")]
    public int? BcId { get; init; }

    [JsonPropertyName("bcGroupName")]
    public string? BcGroupName { get; init; }

    [JsonPropertyName("allowedOperations")]
    public List<int>? AllowedOperations { get; init; }

    [JsonPropertyName("allowedStatuses")]
    public List<int>? AllowedStatuses { get; init; }

    [JsonPropertyName("channelId")]
    public string? ChannelId { get; init; }

    [JsonPropertyName("channelName")]
    public string? ChannelName { get; init; }

    /// <summary>
    /// Currency code for create requests (e.g., "USD").
    /// </summary>
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }
}

/// <summary>
/// Payment details containing memo and other information.
/// </summary>
public record B2BInvoicePaymentDetails
{
    [JsonPropertyName("memo")]
    public string? Memo { get; init; }
}

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

/// <summary>
/// Transaction information within module data.
/// </summary>
public record B2BInvoicePaymentTransaction
{
    [JsonPropertyName("memo")]
    public string? Memo { get; init; }

    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonPropertyName("rawTransaction")]
    public object? RawTransaction { get; init; }
}

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

/// <summary>
/// Request to update payment processing status.
/// </summary>
public record B2BInvoicePaymentStatusUpdate
{
    [JsonPropertyName("processingStatus")]
    public int ProcessingStatus { get; init; }
}

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

/// <summary>
/// Response from creating an offline payment.
/// </summary>
public record B2BInvoicePaymentCreateResponse
{
    [JsonPropertyName("paymentId")]
    public int PaymentId { get; init; }
}
