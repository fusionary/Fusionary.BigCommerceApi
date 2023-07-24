namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Sku: {Sku} Product ID: {ProductId}")]
public record BcProductVariantPost: IExtensionData
{
    private List<BcProductVariantOptionValue>? _optionValues;

    /// <summary>
    /// The cost price of the variant. Not affected by Price List prices.
    /// </summary>
    public BcFloat? CostPrice { get; set; }

    /// <summary>
    /// This variant’s base price on the storefront. If a Price List ID is used, the Price List value will be used.
    /// If a Price List ID is not used, and this value is null, the product’s default price (set in the Product
    /// resource’s price field) will be used as the base price.
    /// </summary>
    public BcFloat? Price { get; set; }

    /// <summary>
    /// This variant’s sale price on the storefront. If a Price List ID is used, the Price List value will be used.
    /// If a Price List ID is not used, and this value is null, the product’s sale price (set in the Product resource’s
    /// price field) will be used as the sale price.
    /// </summary>
    public BcFloat? SalePrice { get; set; }

    public BcFloat? RetailPrice { get; set; }

    public BcFloat? Weight { get; set; }

    public BcFloat? Width { get; set; }

    public BcFloat? Height { get; set; }

    public BcFloat? Depth { get; set; }

    public bool? IsFreeShipping { get; set; }

    public BcFloat? FixedCostShippingPrice { get; set; }

    public bool? PurchasingDisabled { get; set; }

    public string? PurchasingDisabledMessage { get; set; }

    /// <summary>
    /// The UPC code used in feeds for shopping comparison sites and external channel integrations.
    /// </summary>
    public string? Upc { get; set; }

    public int? InventoryLevel { get; set; }

    public int? InventoryWarningLevel { get; set; }

    /// <summary>
    /// Identifies where in a warehouse the variant is located.
    /// </summary>
    /// <remarks>
    /// MaxLength: 255
    /// </remarks>
    public string? BinPickingNumber { get; set; }

    public string? ImageUrl { get; set; } = null!;

    /// <summary>
    /// Global Trade Item Number
    /// </summary>
    public string? Gtin { get; set; }

    /// <summary>
    /// Manufacturer Part Number
    /// </summary>
    public string? Mpn { get; set; }

    public int ProductId { get; set; }

    /// <summary>
    /// SKU
    /// </summary>
    /// <remarks>
    /// Required - MaxLength: 255
    /// </remarks>
    public string Sku { get; set; } = null!;

    /// <summary>
    /// Array of option and option values IDs that make up this variant. Will be empty if the variant is the product's base
    /// variant.
    /// </summary>
    public List<BcProductVariantOptionValue> OptionValues
    {
        get => LazyInitializer.EnsureInitialized(ref _optionValues);
        set => _optionValues = value;
    }

    /// <inheritdoc />
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? ExtensionData { get; set; }
}
