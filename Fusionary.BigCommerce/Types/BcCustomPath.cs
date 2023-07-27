namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("{Path}")]
public record BcCustomPath
{
    [JsonPropertyName("path")]
    public string Path { get; set; } = null!;

    /// <summary>
    /// Returns true if the URL has been changed from its default state (the auto-assigned URL that BigCommerce provides).
    /// </summary>
    [JsonPropertyName("is_customized")]
    public bool IsCustomized { get; set; }
}