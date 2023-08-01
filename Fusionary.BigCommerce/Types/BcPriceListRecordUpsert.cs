namespace Fusionary.BigCommerce.Types;

public record BcPriceListRecordUpsert
{
    private BcBulkPricingTier[]? _bulkPricingTiers;

    /// <summary>
    /// The SKU for the variant with which this price set is associated. Either sku or variant_id is required.
    /// </summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>
    /// The variant ID with which this price set is associated. Either variant_id or sku is required.
    /// </summary>
    [JsonPropertyName("variant_id")]
    public int? VariantId { get; set; }

    /// <summary>
    /// The list price for the variant mapped in a Price List. Overrides any existing or Catalog list price for the
    /// variant/product.
    /// </summary>
    [JsonPropertyName("price")]
    public BcFloat Price { get; set; }

    /// <summary>
    /// The sale price for the variant mapped in a Price List. Overrides any existing or Catalog sale price for the
    /// variant/product. If empty, the sale price will be treated as not being set on this variant.
    /// </summary>
    [JsonPropertyName("sale_price")]
    public BcFloat SalePrice { get; set; }

    /// <summary>
    /// The retail price for the variant mapped in a Price List. Overrides any existing or Catalog retail price for the
    /// variant/product. If empty, the retail price will be treated as not being set on this variant.
    /// </summary>
    [JsonPropertyName("retail_price")]
    public BcFloat RetailPrice { get; set; }

    /// <summary>
    /// The MAP (Minimum Advertised Price) for the variant mapped in a Price List. Overrides any existing or Catalog MAP price
    /// for the variant/product. If empty, the MAP price will be treated as not being set on this variant.
    /// </summary>
    [JsonPropertyName("map_price")]
    public BcFloat MapPrice { get; set; }

    /// <summary>
    /// The 3-letter currency code with which this price set is associated.
    /// </summary>
    [JsonPropertyName("currency")]
    public string Currency { get; set; } = null!;


    [JsonPropertyName("bulk_pricing_tiers")]
    public BcBulkPricingTier[] BulkPricingTiers
    {
        get => LazyInitializer.EnsureInitialized(ref _bulkPricingTiers, Array.Empty<BcBulkPricingTier>);
        set => _bulkPricingTiers = value;
    }
}
