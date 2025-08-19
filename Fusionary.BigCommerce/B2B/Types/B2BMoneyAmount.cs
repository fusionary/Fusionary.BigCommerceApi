namespace Fusionary.BigCommerce.B2B.Types;

public record B2BMoneyAmount
{
    [JsonPropertyName("code")]
    public string? CurrencyCode { get; init; }
    
    [JsonPropertyName("values")]
    public string? Value { get; init; }
}