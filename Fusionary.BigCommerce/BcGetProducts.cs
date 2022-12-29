using Microsoft.AspNetCore.Http;

namespace Fusionary.BigCommerce;

public class BcGetProducts : BcRequestBuilder<BcGetProducts>
{
    internal BcGetProducts(IBigCommerceApi api, QueryString queryString) : base(api, queryString)
    { }

    /// <summary>
    /// Filter items by availability.
    /// </summary>
    public BcGetProducts Availability(BcAvailability availability) =>
        Add(BcProductFilter.Availability, availability.ToValue());

    /// <summary>
    /// Filter items by brand_id.
    /// </summary>
    public BcGetProducts Brand(int brandId) => Add(BcProductFilter.BrandId, brandId);

    /// <summary>
    /// Filter items by categories. If a product is in more than one category, using this query will not return the
    /// product. Instead use categories:in=12
    /// </summary>
    public BcGetProducts Categories(int categoryId) => Add(BcProductFilter.Categories, categoryId);

    /// <summary>
    /// Filter items by categories. Use for products in multiple categories. For example, categories:in=12.
    /// </summary>
    public BcGetProducts CategoriesIn(int categoryId) => Add(BcProductFilter.CategoriesIn, categoryId);

    /// <summary>
    /// Filter items by condition.
    /// </summary>
    public BcGetProducts Condition(BcCondition condition) => Add(BcProductFilter.Condition, condition.ToValue());

    /// <summary>
    /// Sort direction.
    /// </summary>
    public BcGetProducts Direction(BcDirection direction) => Add(BcProductFilter.Direction, direction.ToValue());

    /// <summary>
    /// Sub-resources to include on a product, in a comma-separated list. If options or modifiers is used, results are
    /// limited to 10 per page.
    /// </summary>
    /// <example>
    /// variants, images, custom_fields, bulk_pricing_rules, primary_image, modifiers, options, videos
    /// </example>
    public BcGetProducts Include(params string[] values) => Add(BcProductFilter.Include, values);

    /// <summary>
    /// Sub-resources to include on a product, in a comma-separated list. If options or modifiers is used, results are
    /// limited to 10 per page.
    /// </summary>
    public BcGetProducts Include(params BcProductInclude[] values) =>
        Include(values.Select(x => x.ToValue()).ToArray());

    /// <summary>
    /// Fields to include, in a comma-separated list. The ID and the specified fields will be returned.
    /// </summary>
    public BcGetProducts IncludeFields(params string[] values) => Add(BcProductFilter.IncludeFields, values);

    /// <summary>
    /// Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot
    /// be excluded.
    /// </summary>
    public BcGetProducts ExcludeFields(params string[] values) => Add(BcProductFilter.ExcludeFields, values);

    /// <summary>
    /// Filter items by id.
    /// </summary>
    public BcGetProducts Id(int id) => Add(BcProductFilter.Id, id);

    /// <summary>
    /// Filter items by is_featured.
    /// </summary>
    public BcGetProducts IsFeatured(BcBit isFeatured) => Add(BcProductFilter.IsFeatured, isFeatured.ToValue());

    /// <summary>
    /// Filter items by is_free_shipping.
    /// </summary>
    public BcGetProducts IsFreeShipping(BcBit isFreeShipping) =>
        Add(BcProductFilter.IsFreeShipping, isFreeShipping.ToValue());

    /// <summary>
    /// Filter items by ids.
    /// </summary>
    public BcGetProducts IdIn(params int[] id) => Add(BcProductFilter.IdIn, id);

    /// <summary>
    /// Controls the number of items per page in a limited (paginated) list of products.
    /// </summary>
    public BcGetProducts Limit(int limit) => Add(BcProductFilter.Limit, limit);

    /// <summary>
    /// Specifies the page number in a limited (paginated) list of products.
    /// </summary>
    public BcGetProducts Page(int page) => Add(BcProductFilter.Page, page);

    /// <summary>
    /// Filter items by price.
    /// </summary>
    public BcGetProducts Price(decimal price) => Add(BcProductFilter.Price, price);

    /// <summary>
    /// Filter items by status.
    /// </summary>
    public BcGetProducts Status(int status) => Add(BcProductFilter.Status, status);

    /// <summary>
    /// Filter items by keywords found in the name or sku fields
    /// </summary>
    public BcGetProducts Keyword(string keyword) => Add(BcProductFilter.Keyword, keyword);

    /// <summary>
    /// Filter items by name.
    /// </summary>
    public BcGetProducts Name(string name) => Add(BcProductFilter.Name, name);

    /// <summary>
    /// Filter items by out_of_stock. To enable the filter, pass out_of_stock=1.
    /// </summary>
    public BcGetProducts OutOfStock() => Add(BcProductFilter.OutOfStock, "1");

    /// <summary>
    /// Filter items by main SKU. To filter by variant SKU, see Get All Variants.
    /// </summary>
    public BcGetProducts Sku(string sku) => Add(BcProductFilter.Sku, sku);

    /// <summary>
    /// Filter items by SKU.
    /// </summary>
    public BcGetProducts SkuIn(params string[] sku) => Add(BcProductFilter.SkuIn, sku);

    /// <summary>
    /// Field name to sort by. Note: Since id increments when new products are added, you can use that field to sort by
    /// product create date.
    /// </summary>
    public BcGetProducts Sort(BcProductSort sort) => Add(BcProductFilter.Sort, sort.ToValue());

    /// <summary>
    /// Filter items by type.
    /// </summary>
    public BcGetProducts Type(BcProductType type) => Add(BcProductFilter.Type, type.ToValue());

    public Task<BcResponse<BcObject[]>> SendAsync(CancellationToken cancellationToken) =>
        SendAsync<BcObject>(cancellationToken);

    public async Task<BcResponse<TProduct[]>> SendAsync<TProduct>(CancellationToken cancellationToken) =>
        await Api.GetAsync<BcResponse<TProduct[]>>(
            BcEndpoint.ProductsV3(),
            Filter,
            cancellationToken
        );
}