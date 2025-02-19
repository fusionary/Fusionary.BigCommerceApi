namespace Fusionary.BigCommerce.Operations;

public record BcOrderShippingQuote
{
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}