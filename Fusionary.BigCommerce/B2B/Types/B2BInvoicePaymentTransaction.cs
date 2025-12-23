namespace Fusionary.BigCommerce.B2B.Types;

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