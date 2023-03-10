namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("{Name}:{Value}")]
public record BcNameValue
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("value")]
    public string Value { get; set; } = null!;
}