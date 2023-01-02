namespace Fusionary.BigCommerce;

public class BcDeleteProducts : BcRequestBuilder<BcDeleteProducts>
{
    internal BcDeleteProducts(IBigCommerceApi api) : base(api)
    { }
    
    /// <summary>
    /// Filter items by brand_id.
    /// </summary>
    public BcDeleteProducts Brand(int brandId) => Add("brand_id", brandId);

    /// <summary>
    /// Filter items by categories. If a product is in more than one category, using this query will not return the
    /// product. Instead use categories:in=12
    /// </summary>
    public BcDeleteProducts Categories(int categoryId) => Add("categories", categoryId);

    /// <summary>
    /// Filter items by categories. Use for products in multiple categories. For example, categories:in=12.
    /// </summary>
    public BcDeleteProducts CategoriesIn(int categoryId) => Add("categories:in", categoryId);

    /// <summary>
    /// Filter items by condition.
    /// </summary>
    public BcDeleteProducts Condition(BcCondition condition) => Add("condition", condition.ToValue());
    
    /// <summary>
    /// Filter items by date_modified. For example v3/catalog/products?date_modified:min=2018-06-15
    /// </summary>
    public BcDeleteProducts DateModified(DateOnly date, BcRange range = BcRange.None) => Add(range.Apply("date_modified"), date);
    
   
    /// <summary>
    /// Filter items by date_last_imported. For example v3/catalog/products?date_last_imported:max=2018-06-15
    /// </summary>
    public BcDeleteProducts DateLastImported(DateOnly date, BcRange range = BcRange.None) => Add(range.Apply("date_last_imported"), date);

    /// <summary>
    /// Filter items by inventory_level.
    /// </summary>
    public BcDeleteProducts InventoryLevel(int inventoryLevel) => Add("inventory_level", inventoryLevel);

    /// <summary>
    /// Filter items by is_featured.
    /// </summary>
    public BcDeleteProducts IsFeatured(BcBit isFeatured) => Add("is_featured", isFeatured.ToValue());

    /// <summary>
    /// Filter items by if visible on the storefront.
    /// </summary>
    public BcDeleteProducts IsVisible(bool isVisible) => Add("is_visible", isVisible);

    /// <summary>
    /// Filter items by ids.
    /// </summary>
    public BcDeleteProducts IdIn(params int[] id) => Add("id:in", id);
    
    /// <summary>
    /// Filter items by price.
    /// </summary>
    public BcDeleteProducts Price(decimal price) => Add("price", price);
    
    /// <summary>
    /// Filter items by keywords found in the name or sku fields
    /// </summary>
    public BcDeleteProducts Keyword(string keyword) => Add("keyword", keyword);

    /// <summary>
    /// Filter items by name.
    /// </summary>
    public BcDeleteProducts Name(string name) => Add("name", name);

    /// <summary>
    /// Filter items by main SKU. To filter by variant SKU, see Get All Variants.
    /// </summary>
    public BcDeleteProducts Sku(string sku) => Add("sku", sku);
    
    /// <summary>
    /// Filter items by total_sold.
    /// </summary>
    public BcDeleteProducts TotalSold(int totalSold) => Add("total_sold", totalSold);

    /// <summary>
    /// Filter items by type.
    /// </summary>
    public BcDeleteProducts Type(BcProductType type) => Add("type", type.ToValue());
    
    /// <summary>
    /// Filter items by weight.
    /// </summary>
    public BcDeleteProducts Weight(double weight) => Add("weight", weight);
    
    public async Task<bool> SendAsync(CancellationToken cancellationToken) =>
        await Api.DeleteAsync(
            BcEndpoint.ProductsV3(),
            Filter,
            cancellationToken
        );
}