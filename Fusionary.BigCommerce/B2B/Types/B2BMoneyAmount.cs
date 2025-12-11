namespace Fusionary.BigCommerce.B2B.Types;

public record B2BMoneyAmount
{
    [JsonPropertyName("code")]
    public string? CurrencyCode { get; init; }
    
    [JsonPropertyName("value")]
    public string? Value { get; init; }
}