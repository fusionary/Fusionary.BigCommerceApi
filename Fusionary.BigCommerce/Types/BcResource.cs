namespace Fusionary.BigCommerce.Types;

public record BcResource
{
    [JsonPropertyName("url")]
    public string Url { get; set; } = null!;
    
    [JsonPropertyName("resource")]
    public string Resource { get; set; } = null!;
}