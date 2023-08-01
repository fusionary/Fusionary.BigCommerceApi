namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Brand {Name}")]
public record BcBrandPost : IExtensionData
{
    /// <summary>
    /// The name of the brand. Must be unique
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Comma-separated list of meta keywords to include in the HTML.
    /// </summary>
    public List<string>? MetaKeywords { get; init; }

    /// <summary>
    /// A meta description to include.
    /// </summary>
    public string? MetaDescription { get; init; }

    /// <summary>
    /// Image URL used for this category on the storefront. Images can be uploaded via form file post to
    /// /brands/{brandId}/image, or by providing a publicly accessible URL in this field.
    /// </summary>
    public string? ImageUrl { get; init; }

    /// <summary>
    /// A comma-separated list of keywords that can be used to locate this brand.
    /// </summary>
    public string? SearchKeywords { get; init; }

    /// <summary>
    /// The custom URL for the brand on the storefront.
    /// </summary>
    public BcCustomUrl? CustomUrl { get; init; }

    /// <inheritdoc />
    public IDictionary<string, JsonElement>? ExtensionData { get; init; }
}
