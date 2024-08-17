namespace Fusionary.BigCommerce.Types;

public record BcProductModifierPost : IExtensionData
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; } = null!;

    public BcProductModifierType Type { get; set; }

    public bool Required { get; set; }

    public BcOptionConfig? Config { get; set; }

    public List<BcModifierOptionValue>? OptionValues { get; set; }

   

    /// <inheritdoc />
    public IDictionary<string, JsonElement>? ExtensionData { get; init; }
}