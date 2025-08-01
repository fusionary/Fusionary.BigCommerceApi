using System.ComponentModel.DataAnnotations;

namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Product: {Name} - {Sku}")]
public record BcProductPost : BcExtensionData
{
    private List<int>? _categories;

    /// <summary>
    /// A unique product name.
    /// </summary>
    /// <remarks>
    /// Required - Maxlength 250 characters
    /// </remarks>
    [StringLength(250, MinimumLength = 1)]
    public string Name { get; init; } = null!;

    /// <summary>
    /// The product type
    /// </summary>
    public BcProductType Type { get; init; } = BcProductType.Physical;

    /// <summary>
    /// A unique user-defined product code/stock keeping unit
    /// </summary>
    /// <remarks>
    /// &gt;= 1 characters<br />&lt;= 250 characters
    /// </remarks>
    [MaxLength(255)]
    public string? Sku { get; set; }

    /// <summary>
    /// The product description, which can include HTML formatting.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Weight of the product, which can be used when calculating shipping costs. This is based on the unit set on the store
    /// </summary>
    /// <remarks>
    /// Required
    /// </remarks>
    public double Weight { get; init; } = 0.0;

    /// <summary>
    /// Width of the product, which can be used when calculating shipping costs.
    /// </summary>
    public double? Width { get; set; }

    /// <summary>
    /// Depth of the product, which can be used when calculating shipping costs.
    /// </summary>
    public double? Depth { get; set; }

    /// <summary>
    /// Height of the product, which can be used when calculating shipping costs.
    /// </summary>
    public double? Height { get; set; }

    /// <summary>
    /// The price of the product. The price should include or exclude tax, based on the store settings.
    /// </summary>
    /// <remarks>
    /// Required
    /// </remarks>
    public required BcFloat Price { get; init; }

    /// <summary>
    /// The cost price of the product. Stored for reference only; it is not used or displayed anywhere on the store.
    /// </summary>
    public BcFloat CostPrice { get; set; }

    /// <summary>
    /// The retail cost of the product. If entered, the retail cost price will be shown on the product page.
    /// </summary>
    public BcFloat RetailPrice { get; set; }

    /// <summary>
    /// If entered, the sale price will be used instead of value in the price field when calculating the product's cost.
    /// </summary>
    public BcFloat SalePrice { get; set; }

    /// <summary>
    /// Minimum Advertised Price (MAP) for the product.
    /// </summary>
    public BcFloat MapPrice { get; set; }

    /// <summary>
    /// The ID of the tax class applied to the product. (NOTE: Value ignored if automatic tax is enabled.)
    /// </summary>
    public int? TaxClassId { get; set; }

    /// <summary>
    /// Accepts AvaTax System Tax Codes, which identify products and services that fall into special sales-tax categories.
    /// By using these codes, merchants who subscribe to BigCommerce's Avalara Premium integration can calculate sales
    /// taxes more accurately. Stores without Avalara Premium will ignore the code when calculating sales tax. Do not
    /// pass more than one code. The codes are case-sensitive. For details, please see Avalara's documentation.
    /// </summary>
    /// <remarks>
    /// &gt;= 1 characters<br />&lt;= 255 characters
    /// </remarks>
    [MaxLength(255)]
    public string? ProductTaxCode { get; set; }

    /// <summary>
    /// The price of the product as seen on the storefront. It will be equal to the sale_price, if set, and the price
    /// if there is not a sale_price.
    /// </summary>
    public BcFloat CalculatedPrice { get; set; }

    /// <summary>
    /// An array of IDs for the categories to which this product belongs. When updating a product, if an array of
    /// categories is supplied, all product categories will be overwritten. Does not accept more than 1,000 ID values.
    /// </summary>
    public List<int> Categories
    {
        get => LazyInitializer.EnsureInitialized(ref _categories);
        set => _categories = value;
    }

    /// <summary>
    /// A product can be added to an existing brand during a product /PUT or /POST.
    /// </summary>
    public int? BrandId { get; set; }

    /// <summary>
    /// The brand can be created during a product PUT or POST request. If the brand already exists then the product
    /// will be added. If not the brand will be created and the product added. If using brand_name it performs a fuzzy
    /// match and adds the brand. eg. "Common Good" and "Common good" are the same. Brand name does not return as part
    /// of a product response. Only the brand_id.
    /// </summary>
    public string? BrandName { get; set; }

    /// <summary>
    /// Indicates that the product is in an Option Set (legacy V2 concept).
    /// </summary>
    public int? OptionSetId { get; set; }

    /// <summary>
    /// Legacy template setting which controls if the option set shows up to the side of or below the product image
    /// and description.
    /// </summary>
    public string? OptionSetDisplay { get; set; }

    /// <summary>
    /// Current inventory level of the product. Simple inventory tracking must be enabled (See the inventory_tracking
    /// field) for this to take any effect.
    /// </summary>
    public int? InventoryLevel { get; set; }

    /// <summary>
    /// Inventory warning level for the product. When the product's inventory level drops below the warning level, the
    /// store owner will be informed. Simple inventory tracking must be enabled (see the inventory_tracking field) for
    /// this to take any effect.
    /// </summary>
    public int? InventoryWarningLevel { get; set; }

    /// <summary>
    /// The type of inventory tracking for the product. Values are:<br />
    /// - none: inventory levels will not be tracked;<br />
    /// - product: inventory levels will be tracked using the inventory_level and inventory_warning_level fields;<br />
    /// - variant: inventory levels will be tracked based on variants, which maintain their own warning levels and inventory
    /// levels.<br />
    /// </summary>
    public BcInventoryTracking? InventoryTracking { get; set; }

    /// <summary>
    /// The total (cumulative) rating for the product.
    /// </summary>
    public int ReviewsRatingSum { get; set; }

    /// <summary>
    /// The number of times the product has been rated.
    /// </summary>
    public int ReviewsCount { get; set; }

    /// <summary>
    /// The total quantity of this product sold.
    /// </summary>
    public int TotalSold { get; set; }

    /// <summary>
    /// A fixed shipping cost for the product. If defined, this value will be used during checkout instead of normal
    /// shipping-cost calculation.
    /// </summary>
    public BcFloat FixedCostShippingPrice { get; set; }

    /// <summary>
    /// Flag used to indicate whether the product has free shipping. If true, the shipping cost for the product will
    /// be zero.
    /// </summary>
    public bool IsFreeShipping { get; set; }

    /// <summary>
    /// Flag to determine whether the product should be displayed to customers browsing the store. If true, the product
    /// will be displayed. If false, the product will be hidden from view.
    /// </summary>
    public bool IsVisible { get; set; }

    /// <summary>
    /// Flag to determine whether the product should be included in the featured products panel when viewing the store.
    /// </summary>
    public bool IsFeatured { get; set; }

    /// <summary>
    /// An array of IDs for the related products.
    /// </summary>
    public List<int>? RelatedProducts { get; set; }

    /// <summary>
    /// Warranty information displayed on the product page. Can include HTML formatting.
    /// </summary>
    public string? Warranty { get; set; }

    /// <summary>
    /// The BIN picking number for the product.
    /// </summary>
    /// <remarks>
    /// &gt;= 0 characters<br />&lt;= 255 characters
    /// </remarks>
    [MaxLength(255)]
    public string? BinPickingNumber { get; set; }

    /// <summary>
    /// The layout template file used to render this product category. This field is writable only for stores with a
    /// Blueprint theme applied. For stores with a Stencil theme applied, see
    /// https://developer.bigcommerce.com/api-reference/store-management/custom-template-associations
    /// </summary>
    /// <remarks>
    /// &gt;= 1 characters<br />&lt;= 500 characters
    /// </remarks>
    public string? LayoutFile { get; set; }

    /// <summary>
    /// The product UPC code, which is used in feeds for shopping comparison sites and external channel integrations.
    /// </summary>
    /// <remarks>
    /// &gt;= 0 characters<br />&lt;= 32 characters
    /// </remarks>
    [MaxLength(32)]
    public string? Upc { get; set; }

    /// <summary>
    /// Manufacturer Part Number
    /// </summary>
    public string? Mpn { get; set; }

    /// <summary>
    /// Global Trade Item Number
    /// </summary>
    public string? Gtin { get; set; }

    /// <summary>
    /// A comma-separated list of keywords that can be used to locate the product when searching the store.
    /// </summary>
    public string? SearchKeywords { get; set; }

    /// <summary>
    /// Availability of the product. (Corresponds to the product's Purchasability section in the control panel.)
    /// </summary>
    public BcAvailability? Availability { get; set; }

    /// <summary>
    /// Availability text displayed on the checkout page, under the product title. Tells the customer how long it will
    /// normally take to ship this product, such as: 'Usually ships in 24 hours.'
    /// </summary>
    /// <remarks>
    /// &gt;= 0 characters<br />&lt;= 255 characters
    /// </remarks>
    public string? AvailabilityDescription { get; set; }

    /// <summary>
    /// Type of gift-wrapping options.
    /// </summary>
    public BcGiftWrappingOptionsType? GiftWrappingOptionsType { get; set; }

    /// <summary>
    /// A list of possible the gift-wrapping option IDs when <see cref="GiftWrappingOptionsType" /> is set
    /// to <see cref="BcGiftWrappingOptionsType.List" />.
    /// </summary>
    public List<int>? GiftWrappingOptionsList { get; set; }

    /// <summary>
    /// Priority to give this product when included in product lists on category pages and in search results. Lower integers
    /// will place the product closer to the top of the results.
    /// </summary>
    /// <remarks>
    /// &gt;= <c>int.MinValue</c><br />&lt;= <c>int.MaxValue</c>
    /// </remarks>
    public int? SortOrder { get; set; }

    /// <summary>
    /// The product condition. Will be shown on the product page if the <see cref="IsConditionShown" /> field's value
    /// is <see langword="true" />.
    /// </summary>
    public string? Condition { get; set; }

    /// <summary>
    /// Flag used to determine whether the product condition is shown to the customer on the product page
    /// </summary>
    public bool? IsConditionShown { get; set; }

    /// <summary>
    /// The minimum quantity an order must contain, to be eligible to purchase this product.
    /// </summary>
    public int? OrderQuantityMinimum { get; set; }

    /// <summary>
    /// The maximum quantity an order can contain when purchasing the product.
    /// </summary>
    public int? OrderQuantityMaximum { get; set; }

    /// <summary>
    /// Custom title for the product page. If not defined, the product name will be used as the meta
    /// </summary>
    public string? PageTitle { get; set; }

    /// <summary>
    /// Custom meta keywords for the product page. If not defined, the store's default keywords will be used.
    /// </summary>
    public List<string>? MetaKeywords { get; set; }

    /// <summary>
    /// Custom meta description for the product page. If not defined, the store's default meta description will be used.
    /// </summary>
    public string? MetaDescription { get; set; }

    /// <summary>
    /// The date on which the product was created.
    /// </summary>
    public BcDateTime DateCreated { get; set; }

    /// <summary>
    /// The date on which the product was modified.
    /// </summary>
    public BcDateTime DateModified { get; set; }

    /// <summary>
    /// The number of times the product has been viewed.
    /// </summary>
    public int? ViewCount { get; set; }

    /// <summary>
    /// Pre-order release date. See the availability field for details on setting a product's availability to
    /// accept pre-orders.
    /// </summary>
    public string? PreorderReleaseDate { get; set; }

    /// <summary>
    /// Custom expected-date message to display on the product page. If undefined, the message defaults to the
    /// storewide setting. Can contain the %%DATE%% placeholder, which will be substituted for the release date.
    /// </summary>
    /// <remarks>
    /// &gt;= 0 characters<br />&lt;= 255 characters
    /// </remarks>
    [MaxLength(255)]
    public string? PreorderMessage { get; set; }

    /// <summary>
    /// If set to true then on the preorder release date the preorder status will automatically be removed.
    /// If set to false, then on the release date the preorder status will not be removed. It will need to be
    /// changed manually either in the control panel or using the API. Using the API set availability to available.
    /// </summary>
    public bool? IsPreorderOnly { get; set; }

    /// <summary>
    /// False by default, indicating that this product's price should be shown on the product page. If set to true, the
    /// price is hidden. (NOTE: To successfully set is_price_hidden to true, the availability value must be disabled.)
    /// </summary>
    public bool? IsPriceHidden { get; set; }

    /// <summary>
    /// By default, an empty string. If is_price_hidden is true, the value of price_hidden_label is displayed instead
    /// of the price. (NOTE: To successfully set a non-empty string value with is_price_hidden set to true, the
    /// availability value must be disabled.)
    /// </summary>
    /// <remarks>
    /// &gt;= 0 characters<br />&lt;= 200 characters
    /// </remarks>
    [MaxLength(200)]
    public string? PriceHiddenLabel { get; set; }

    /// <summary>
    /// The custom URL for the product on the storefront.
    /// </summary>
    public BcCustomUrl? CustomUrl { get; set; }

    /// <summary>
    /// The unique identifier of the base variant associated with a simple product. This value is null for complex
    /// products.
    /// </summary>
    public int? BaseVariantId { get; set; }

    /// <summary>
    /// Type of product
    /// </summary>
    public BcOpenGraphType? OpenGraphType { get; set; }

    /// <summary>
    /// Title of the product, if not specified the product name will be used instead.
    /// </summary>
    public string? OpenGraphTitle { get; set; }

    /// <summary>
    /// Description to use for the product, if not specified then the meta_description will be used instead.
    /// </summary>
    public string? OpenGraphDescription { get; set; }

    /// <summary>
    /// Flag to determine if product description or open graph description is used.
    /// </summary>
    public bool? OpenGraphUseMetaDescription { get; set; }

    /// <summary>
    /// Flag to determine if product name or open graph name is used.
    /// </summary>
    public bool? OpenGraphUseProductName { get; set; }

    /// <summary>
    /// Flag to determine if product image or open graph image is used.
    /// </summary>
    public bool? OpenGraphUseImage { get; set; }

    /// <summary>
    /// Custom fields.
    /// </summary>
    public List<BcCustomFieldPost>? CustomFields { get; set; }

    /// <summary>
    /// Bulk pricing rules.
    /// </summary>
    public List<BcProductBulkPricingRule>? BulkPricingRules { get; set; }

    /// <summary>
    /// Images
    /// </summary>
    public List<BcProductImage>? Images { get; set; }

    /// <summary>
    /// Videos
    /// </summary>
    public List<BcProductVideo>? Videos { get; set; }

    /// <summary>
    /// Variants
    /// </summary>
    public List<BcProductVariant>? Variants { get; set; }
}