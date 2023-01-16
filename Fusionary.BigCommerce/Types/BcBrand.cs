namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Brand {Id}:{Name}")]
public record BcBrand
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public List<string>? MetaKeywords { get; set; }

    public string? MetaDescription { get; set; }

    public string? ImageUrl { get; set; }

    public string? SearchKeywords { get; set; }

    public BcCustomUrl? CustomUrl { get; set; }
}