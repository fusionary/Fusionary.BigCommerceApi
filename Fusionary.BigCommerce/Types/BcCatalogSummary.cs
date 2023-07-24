namespace Fusionary.BigCommerce.Types;

public record BcCatalogSummary
{
    public int InventoryCount { get; set; }

    public BcFloat InventoryValue { get; set; }

    public int PrimaryCategoryId { get; set; }

    public string PrimaryCategoryName { get; set; } = null!;

    public int VariantCount { get; set; }

    public BcFloat HighestVariantPrice { get; set; }

    public BcFloat AverageVariantPrice { get; set; }

    public BcFloat LowestVariantPrice { get; set; }

    public BcDateTime OldestVariantDate { get; set; }

    public BcDateTime NewestVariantDate { get; set; }
}
