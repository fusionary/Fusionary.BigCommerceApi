namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("{InventoryCount}")]
public record BcCatalogSummary
{
    /// <summary>
    /// A count of all inventory items in the catalog.
    /// </summary>
    public int InventoryCount { get; init; }

    /// <summary>
    /// Total value of store's inventory.
    /// </summary>
    public BcFloat InventoryValue { get; init; }

    /// <summary>
    /// ID of the category containing the most products.
    /// </summary>
    public int PrimaryCategoryId { get; init; }

    /// <summary>
    /// Total number of variants
    /// </summary>
    public string PrimaryCategoryName { get; init; } = null!;

    /// <summary>
    /// Total number of variants
    /// </summary>
    public int VariantCount { get; init; }

    /// <summary>
    /// Highest priced variant
    /// </summary>
    public BcFloat HighestVariantPrice { get; init; }

    /// <summary>
    /// Average price of all variants
    /// </summary>
    public BcFloat AverageVariantPrice { get; init; }

    /// <summary>
    /// Lowest priced variant in the store
    /// </summary>
    public BcFloat LowestVariantPrice { get; init; }


    /// <summary>
    /// Oldest variant in the store
    /// </summary>
    public BcDateTime OldestVariantDate { get; init; }

    /// <summary>
    /// Newest variant in the store
    /// </summary>
    public BcDateTime NewestVariantDate { get; init; }
}
