using Fusionary.BigCommerce.Types;

namespace Fusionary.BigCommerce.Operations;

public record BcProductsSearch : BcRequestBuilder<BcProductsSearch>
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
    /// Filter items by date_modified. For example v3/catalog/products?date_modified:min=2018-06-15
    /// </summary>
    public BcProductsSearch DateModified(DateOnly date, BcRange range = BcRange.None) =>
        Add(range.Apply("date_modified"), date);


    /// <summary>
    /// Filter items by date_last_imported. For example v3/catalog/products?date_last_imported:max=2018-06-15
    /// </summary>
    public BcProductsSearch DateLastImported(DateOnly date, BcRange range = BcRange.None) =>
        Add(range.Apply("date_last_imported"), date);

    /// <summary>
    /// Sort direction.
    /// </summary>
    public BcProductsSearch Direction(BcDirection direction) => Add("direction", direction.ToValue());

    /// <summary>
    /// Sub-resources to include on a product, in a comma-separated list. If options or modifiers is used, results are
    /// limited to 10 per page.
    /// </summary>
    /// <example>
    /// variants, images, custom_fields, bulk_pricing_rules, primary_image, modifiers, options, videos
    /// </example>
    public BcProductsSearch Include(params string[] values) => Add("include", values);

    /// <summary>
    /// Sub-resources to include on a product, in a comma-separated list. If options or modifiers is used, results are
    /// limited to 10 per page.
    /// </summary>
    public BcProductsSearch Include(params BcProductInclude[] values) =>
        Include(values.Select(x => x.ToValue()).ToArray());

    /// <summary>
    /// Fields to include, in a comma-separated list. The ID and the specified fields will be returned.
    /// </summary>
    public BcProductsSearch IncludeFields(params string[] values) => Add("include_fields", values);

    /// <summary>
    /// Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot
    /// be excluded.
    /// </summary>
    public BcProductsSearch ExcludeFields(params string[] values) => Add("exclude_fields", values);

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
    /// Filter items based on whether the product is currently visible on the storefront.
    /// </summary>
    public BcProductsSearch IsVisible(bool isVisible) => Add("is_visible", isVisible);

    /// <summary>
    /// Filter items by is_free_shipping.
    /// </summary>
    public BcProductsSearch IsFreeShipping(BcBit isFreeShipping) => Add("is_free_shipping", isFreeShipping.ToValue());

    /// <summary>
    /// Controls the number of items per page in a limited (paginated) list of products.
    /// </summary>
    public BcProductsSearch Limit(int limit) => Add("limit", limit);

    /// <summary>
    /// Specifies the page number in a limited (paginated) list of products.
    /// </summary>
    public BcProductsSearch Page(int page) => Add("page", page);

    /// <summary>
    /// Filter items by price.
    /// </summary>
    public BcProductsSearch Price(decimal price) => Add("price", price);

    /// <summary>
    /// Filter items by status.
    /// </summary>
    public BcProductsSearch Status(int status) => Add("status", status);

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
    /// Filter items by type.
    /// </summary>
    public BcProductsSearch Type(BcProductType type) => Add("type", type.ToValue());

    /// <summary>
    /// Filter items by total_sold.
    /// </summary>
    public BcProductsSearch TotalSold(int totalSold) => Add("total_sold", totalSold);

    /// <summary>
    /// Filter items by upc.
    /// </summary>
    public BcProductsSearch Upc(string upc) => Add("upc", upc);

    /// <summary>
    /// Filter items by weight.
    /// </summary>
    public BcProductsSearch Weight(int weight) => Add("weight", weight);

    public Task<BcPagedResponse<BcObject>> SendAsync(CancellationToken cancellationToken) =>
        SendAsync<BcObject>(cancellationToken);

    public async Task<BcPagedResponse<T>> SendAsync<T>(CancellationToken cancellationToken) =>
        await Api.GetAsync<BcPagedResponse<T>>(
            BcEndpoint.ProductsV3(),
            Filter,
            cancellationToken
        );
}