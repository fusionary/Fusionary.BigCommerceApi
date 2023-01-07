namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("{Url}")]
public record BcCustomUrl
{
    [JsonPropertyName("url")]
    public string Url { get; set; } = null!;

    [JsonPropertyName("is_customized")]
    public bool IsCustomized { get; set; }
}