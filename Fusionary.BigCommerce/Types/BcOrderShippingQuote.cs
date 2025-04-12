namespace Fusionary.BigCommerce.Types;

public record BcOrderShippingQuote
{
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}