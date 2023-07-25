using CsvHelper.Configuration.Attributes;

namespace Fusionary.BigCommerce.Import;

public record BcProductCsvImport
{
    [Name("Item")]
    public required string Item { get; set; } = "Product";

    [Name("ID")]
    public string? Id { get; set; }

    [Name("SKU")]
    public string? Sku { get; set; }

    [Name("Options")]
    public string? Options { get; set; }

    [Name("Current Stock")]
    public int? CurrentStock { get; set; }

    [Name("Low Stock")]
    public int? LowStock { get; set; }

    [Name("Price")]
    public decimal Price { get; set; }

    [Name("Cost Price")]
    public decimal? CostPrice { get; set; }

    [Name("Retail Price")]
    public decimal? RetailPrice { get; set; }

    [Name("Sale Price")]
    public decimal? SalePrice { get; set; }

    [Name("Bin Picking Number")]
    public int? BinPickingNumber { get; set; }

    [Name("UPC/EAN")]
    public string? Upc { get; set; }

    [Name("Global Trade Number")]
    public string? GlobalTradeNumber { get; set; }

    [Name("Manufacturer Part Number")]
    public string? ManufacturerPartNumber { get; set; }

    [Name("Free Shipping")]
    public BcImportTrueFalse FreeShipping { get; set; }

    [Name("Fixed Shipping Cost")]
    public double? FixedShippingCost { get; set; }

    [Name("Weight")]
    public double Weight { get; set; }

    [Name("Height")]
    public double? Height { get; set; }

    [Name("Width")]
    public double? Width { get; set; }

    [Name("Depth")]
    public double? Depth { get; set; }

    [Name("Name")]
    public string? Name { get; set; }

    [Name("Type")]
    public BcProductType Type { get; set; }

    [Name("Inventory Tracking")]
    public BcInventoryTracking InventoryTracking { get; set; }

    [Name("Brand ID")]
    public int? BrandId { get; set; }

    [Name("Channels")]
    public string Channels { get; set; } = "1";

    [Name("Categories")]
    public string? Categories { get; set; }

    [Name("Description")]
    public string? Description { get; set; }

    [Name("Custom Fields")]
    public string? CustomFields { get; set; }

    [Name("Page Title")]
    public string? PageTitle { get; set; }

    [Name("Meta Description")]
    public string? MetaDescription { get; set; }

    [Name("Search Keywords")]
    public string? SearchKeywords { get; set; }

    [Name("Meta Keywords")]
    public string? MetaKeywords { get; set; }

    [Name("Is Visible")]
    public BcImportTrueFalse IsVisible { get; set; }

    [Name("Is Featured")]
    public BcImportTrueFalse IsFeatured { get; set; }

    [Name("Warranty")]
    public string? Warranty { get; set; }

    [Name("Tax Class")]
    public int TaxClass { get; set; }

    [Name("Product Condition")]
    public string? ProductCondition { get; set; }

    [Name("Show Product Condition")]
    public BcImportTrueFalse ShowProductCondition { get; set; }

    [Name("Sort Order")]
    public int? SortOrder { get; set; }

    // Image Item

    [Name("Variant Image URL")]
    public string? VariantImageUrl { get; set; }

    [Name("Internal Image URL (Export)")]
    public string? InternalImageUrl { get; set; }

    [Name("Image URL (Import)")]
    public string? ImageUrl { get; set; }

    [Name("Image Description")]
    public string? ImageDescription { get; set; }

    [Name("Image Is Thumbnail")]
    public BcImportTrueFalse ImageIsThumbnail { get; set; }

    [Name("Image Sort Order")]
    public int? ImageSortOrder { get; set; }


    // Video Item

    [Name("YouTube ID")]
    public string? YouTubeId { get; set; }

    [Name("Video Title")]
    public string? VideoTitle { get; set; }

    [Name("Video Description")]
    public string? VideoDescription { get; set; }

    [Name("Video Sort Order")]
    public int? VideoSortOrder { get; set; }

}