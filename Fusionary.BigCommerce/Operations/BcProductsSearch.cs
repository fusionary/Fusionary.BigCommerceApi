namespace Fusionary.BigCommerce.Operations;

public record BcProductsSearch : BcRequestBuilder<BcProductsSearch>,
    IBcPageableFilter,
    IBcExcludeFieldsFilter,
    IBcIncludeFieldsFilter,
    IBcProductIncludeFilter,
    IBcDateLastImportedFilter,
    IBcDateModifiedFilter
{
    internal BcProductsSearch(IBigCommerceApi api) : base(api)
    { }

    /// <summary>
    /// Filter items by availability.
    /// </summary>
    public BcProductsSearch Availability(BcAvailability availability) => Add("availability", availability.ToValue());

    /// <summary>
    /// Filter items by brand_id.
    /// </summary>
    public BcProductsSearch Brand(int brandId) => Add("brand_id", brandId);

    /// <summary>
    /// Filter items by categories. If a product is in more than one category, using this query will not return the
    /// product. Instead use categories:in=12
    /// </summary>
    public BcProductsSearch Categories(int categoryId) => Add("categories", categoryId);

    /// <summary>
    /// Filter items by categories. Use for products in multiple categories. For example, categories:in=12.
    /// </summary>
    public BcProductsSearch CategoriesIn(int categoryId) => Add("categories:in", categoryId);

    /// <summary>
    /// Filter items by condition.
    /// </summary>
    public BcProductsSearch Condition(BcCondition condition) => Add("condition", condition.ToValue());

    /// <summary>
    /// Filter items by id.
    /// </summary>
    public BcProductsSearch Id(int id) => Add("id", id);

    /// <summary>
    /// Filter items by ids.
    /// </summary>
    public BcProductsSearch Id(BcModifier modifier, params int[] id) => Add(modifier.Apply("id"), id);

    /// <summary>
    /// Filter items by inventory_level.
    /// </summary>
    public BcProductsSearch InventoryLevel(BcModifier modifier, int inventoryLevel) =>
        Add(modifier.Apply("inventory_level"), inventoryLevel);

    /// <summary>
    /// Filter items by inventory_low. Values: 1, 0.
    /// </summary>
    public BcProductsSearch InventoryLow(BcBit inventoryLow) => Add("inventory_low", inventoryLow.ToValue());

    /// <summary>
    /// Filter items by is_featured.
    /// </summary>
    public BcProductsSearch IsFeatured(BcBit isFeatured) => Add("is_featured", isFeatured.ToValue());

    /// <summary>
    /// Filter items by is_free_shipping.
    /// </summary>
    public BcProductsSearch IsFreeShipping(BcBit isFreeShipping) => Add("is_free_shipping", isFreeShipping.ToValue());

    /// <summary>
    /// Filter items based on whether the product is currently visible on the storefront.
    /// </summary>
    public BcProductsSearch IsVisible(bool isVisible) => Add("is_visible", isVisible);

    /// <summary>
    /// Filter items by keywords found in the name or sku fields
    /// </summary>
    public BcProductsSearch Keyword(string keyword) => Add("keyword", keyword);

    /// <summary>
    ///     <para>Set context used by the search algorithm to return results targeted towards the specified group.</para>
    ///     <para>Use merchant to help merchants search their own catalog.</para>
    ///     <para>Use shopper to return shopper-facing search results.</para>
    /// </summary>
    /// <example>
    /// shopper, merchant
    /// </example>
    public BcProductsSearch KeywordContext(BcKeywordContext keywordContext) =>
        Add("keyword_context", keywordContext.ToValue());

    /// <summary>
    /// Filter items by name.
    /// </summary>
    public BcProductsSearch Name(string name) => Add("name", name);

    /// <summary>
    /// Filter items by out_of_stock. To enable the filter, pass out_of_stock=1.
    /// </summary>
    public BcProductsSearch OutOfStock() => Add("out_of_stock", "1");

    /// <summary>
    /// Filter items by price.
    /// </summary>
    public BcProductsSearch Price(decimal price) => Add("price", price);

    public Task<BcPagedResult<BcProductFull>> SendAsync(CancellationToken cancellationToken) =>
        SendAsync<BcProductFull>(cancellationToken);

    public async Task<BcPagedResult<T>> SendAsync<T>(CancellationToken cancellationToken) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.ProductsV3(),
            Filter,
            cancellationToken
        );

    /// <summary>
    /// Filter items by main SKU. To filter by variant SKU, see Get All Variants.
    /// </summary>
    public BcProductsSearch Sku(string sku) => Add("sku", sku);

    /// <summary>
    /// Filter items by SKU.
    /// </summary>
    public BcProductsSearch SkuIn(params string[] sku) => Add("sku:in", sku);

    /// <summary>
    /// Field name to sort by. Note: Since id increments when new products are added, you can use that field to sort by
    /// product create date.
    /// </summary>
    public BcProductsSearch Sort(BcProductSort sort) => Add("sort", sort.ToValue());

    /// <summary>
    /// Filter items by status.
    /// </summary>
    public BcProductsSearch Status(int status) => Add("status", status);

    /// <summary>
    /// Filter items by total_sold.
    /// </summary>
    public BcProductsSearch TotalSold(int totalSold) => Add("total_sold", totalSold);

    /// <summary>
    /// Filter items by type.
    /// </summary>
    public BcProductsSearch Type(BcProductType type) => Add("type", type.ToValue());

    /// <summary>
    /// Filter items by upc.
    /// </summary>
    public BcProductsSearch Upc(string upc) => Add("upc", upc);

    /// <summary>
    /// Filter items by weight.
    /// </summary>
    public BcProductsSearch Weight(int weight) => Add("weight", weight);
}