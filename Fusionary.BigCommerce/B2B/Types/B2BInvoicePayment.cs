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