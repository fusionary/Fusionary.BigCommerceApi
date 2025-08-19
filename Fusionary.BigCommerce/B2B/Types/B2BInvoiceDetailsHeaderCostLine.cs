namespace Fusionary.BigCommerce.B2B.Types;

public record B2BInvoiceDetailsHeaderCostLine
{
    [JsonPropertyName("description")]
    public string? Description { get; init; }
    
    [JsonPropertyName("amount")]
    public B2BMoneyAmount? Amount { get; init; }
}