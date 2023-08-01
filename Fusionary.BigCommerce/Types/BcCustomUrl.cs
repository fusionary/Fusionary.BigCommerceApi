namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("{Url}")]
public record BcCustomUrl
{
    [JsonPropertyName("url")]
    public string Url { get; set; } = null!;

    /// <summary>
    /// Returns true if the URL has been changed from its default state (the auto-assigned URL that BigCommerce provides).
    /// </summary>
    [JsonPropertyName("is_customized")]
    public bool IsCustomized { get; set; }
}