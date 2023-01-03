namespace Fusionary.BigCommerce.Types;

public record BcProductVariant
{
    private List<BcOptionValue>? _optionValues;

    public int Id { get; set; }

    public double? CostPrice { get; set; }

    public double? Price { get; set; }

    public double? SalePrice { get; set; }

    public double? RetailPrice { get; set; }

    public double? Weight { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public double? Depth { get; set; }

    public bool IsFreeShipping { get; set; }

    public double? FixedCostShippingPrice { get; set; }

    public bool PurchasingDisabled { get; set; }

    public string? PurchasingDisabledMessage { get; set; }

    /// <summary>
    /// The UPC code used in feeds for shopping comparison sites and external channel integrations.
    /// </summary>
    public string? Upc { get; set; }

    public int? InventoryLevel { get; set; }

    public int? InventoryWarningLevel { get; set; }

    public string? BinPickingNumber { get; set; }

    public string ImageUrl { get; set; } = null!;

    /// <summary>
    /// Global Trade Item Number
    /// </summary>
    public string? Gtin { get; set; }

    /// <summary>
    /// Manufacturer Part Number
    /// </summary>
    public string? Mpn { get; set; }

    public int ProductId { get; set; }

    public string? Sku { get; set; }

    /// <summary>
    /// Array of option and option values IDs that make up this variant. Will be empty if the variant is the product's base
    /// variant.
    /// </summary>
    public List<BcOptionValue> OptionValues
    {
        get => LazyInitializer.EnsureInitialized(ref _optionValues);
        set => _optionValues = value;
    }
}