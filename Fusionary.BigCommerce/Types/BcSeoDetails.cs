namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("SEO Details {PageTitle}")]
public record BcSeoDetails
{
    public string PageTitle { get; set; } = null!;

    public string? MetaDescription { get; set; }

    public string? MetaKeywords { get; set; }
}