namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("OptionValue {Id}: {Label}")]
public record BcOptionValue
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("option_id")]
    public int OptionId { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; } = null!;

    [JsonPropertyName("option_display_name")]
    public string? OptionDisplayName { get; set; }
}