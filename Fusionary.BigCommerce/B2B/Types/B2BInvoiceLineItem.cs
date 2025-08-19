namespace Fusionary.BigCommerce.B2B.Types;

public record B2BInvoiceLineItem
{
    [JsonPropertyName("sku")]
    public string? Sku { get; init; }
    
    [JsonPropertyName("type")]
    public string? Type { get; init; }
    
    [JsonPropertyName("comments")]
    public string? Comments { get; init; }
    
    [JsonPropertyName("quantity")]
    public string? Quantity { get; init; }
    
    [JsonPropertyName("description")]
    public string? Description { get; init; }
    
    [JsonPropertyName("unitPrice")]
    public B2BMoneyAmount? UnitPrice { get; init; }
    
    [JsonPropertyName("unitDiscount")]
    public B2BMoneyAmount? UnitDiscount { get; init; }
}