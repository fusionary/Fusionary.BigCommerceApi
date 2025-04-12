namespace Fusionary.BigCommerce.Types;

public record BcExtensionData : IBcExtensionData
{
    /// <inheritdoc />
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? ExtensionData { get; init; }
}