namespace Fusionary.BigCommerce.Types;

public record BcPriceListPost : IExtensionData
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("active")]
    public bool Active { get; set; }

    public IDictionary<string, JsonElement>? ExtensionData { get; init; }
}