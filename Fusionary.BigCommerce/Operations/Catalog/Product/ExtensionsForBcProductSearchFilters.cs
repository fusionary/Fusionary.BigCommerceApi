namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForBcProductSearchFilters
{
    /// <summary>
    /// Filter items by availability.
    /// </summary>
    public static T Availability<T>(this T builder, BcAvailability availability)
        where T : IBcProductSearchFilter =>
        builder.Add("availability", availability.ToValue());

    /// <summary>
    /// Filter items by brand_id.
    /// </summary>
    public static T Brand<T>(this T builder, int brandId)
        where T : IBcProductDeleteFilter =>
        builder.Add("brand_id", brandId);

    /// <summary>
    /// Filter items by categories. If a product is in more than one category, using builder query will not return the
    /// product. Instead use categories:in=12
    /// </summary>
    public static T Categories<T>(this T builder, int categoryId)
        where T : IBcProductDeleteFilter =>
        builder.Add("categories", categoryId);

    /// <summary>
    /// Filter items by categories. Use for products in multiple categories. For example, categories:in=12.
    /// </summary>
    public static T CategoriesIn<T>(this T builder, int categoryId)
        where T : IBcProductSearchFilter =>
        builder.Add("categories:in", categoryId);

    /// <summary>
    /// Filter items by condition.
    /// </summary>
    public static T Condition<T>(this T builder, BcCondition condition)
        where T : IBcProductDeleteFilter =>
        builder.Add("condition", condition.ToValue());

    /// <summary>
    /// Filter items by inventory_level.
    /// </summary>
    public static T InventoryLevel<T>(this T builder, BcModifier modifier, int inventoryLevel)
        where T : IBcProductDeleteFilter =>
        builder.Add(modifier.Apply("inventory_level"), inventoryLevel);

    /// <summary>
    /// Filter items by inventory_low. Values: 1, 0.
    /// </summary>
    public static T InventoryLow<T>(this T builder, BcBit inventoryLow)
        where T : IBcProductSearchFilter => builder.Add("inventory_low", inventoryLow.ToValue());

    /// <summary>
    /// Filter items by is_featured.
    /// </summary>
    public static T IsFeatured<T>(this T builder, BcBit isFeatured)
        where T : IBcProductDeleteFilter =>
        builder.Add("is_featured", isFeatured.ToValue());

    /// <summary>
    /// Filter items by is_free_shipping.
    /// </summary>
    public static T IsFreeShipping<T>(this T builder, BcBit isFreeShipping)
        where T : IBcProductSearchFilter =>
        builder.Add("is_free_shipping", isFreeShipping.ToValue());

    /// <summary>
    /// Filter items based on whether the product is currently visible on the storefront.
    /// </summary>
    public static T IsVisible<T>(this T builder, bool isVisible)
        where T : IBcProductDeleteFilter =>
        builder.Add("is_visible", isVisible);

    /// <summary>
    /// Filter items by keywords found in the name or sku fields
    /// </summary>
    public static T Keyword<T>(this T builder, string keyword)
        where T : IBcProductDeleteFilter =>
        builder.Add("keyword", keyword);

    /// <summary>
    ///     <para>Set context used by the search algorithm to return results targeted towards the specified group.</para>
    ///     <para>Use merchant to help merchants search their own catalog.</para>
    ///     <para>Use shopper to return shopper-facing search results.</para>
    /// </summary>
    /// <example>
    /// shopper, merchant
    /// </example>
    public static T KeywordContext<T>(this T builder, BcKeywordContext keywordContext)
        where T : IBcProductSearchFilter =>
        builder.Add("keyword_context", keywordContext.ToValue());

    /// <summary>
    /// Filter items by name.
    /// </summary>
    public static T Name<T>(this T builder, string name)
        where T : IBcProductSearchFilter =>
        builder.Add("name", name);

    /// <summary>
    /// Filter items by out_of_stock. To enable the filter, pass out_of_stock=1.
    /// </summary>
    public static T OutOfStock<T>(this T builder)
        where T : IBcProductSearchFilter =>
        builder.Add("out_of_stock", "1");

    /// <summary>
    /// Filter items by price.
    /// </summary>
    public static T Price<T>(this T builder, BcFloat price)
        where T : IBcProductDeleteFilter =>
        builder.Add("price", price);

    /// <summary>
    /// Filter items by main SKU. To filter by variant SKU, see Get All Variants.
    /// </summary>
    public static T Sku<T>(this T builder, string sku)
        where T : IBcProductSearchFilter =>
        builder.Add("sku", sku);

    /// <summary>
    /// Filter items by SKU.
    /// </summary>
    public static T SkuIn<T>(this T builder, IEnumerable<string> sku)
        where T : IBcProductSearchFilter =>
        builder.Add("sku:in", sku);

    /// <summary>
    /// Field name to sort by. Note: Since id increments when new products are added, you can use that field to sort by
    /// product create date.
    /// </summary>
    public static T Sort<T>(this T builder, BcProductSort sort)
        where T : IBcProductSearchFilter =>
        builder.Add("sort", sort.ToValue());

    /// <summary>
    /// Filter items by status.
    /// </summary>
    public static T Status<T>(this T builder, int status)
        where T : IBcProductSearchFilter =>
        builder.Add("status", status);

    /// <summary>
    /// Filter items by total_sold.
    /// </summary>
    public static T TotalSold<T>(this T builder, int totalSold)
        where T : IBcProductDeleteFilter =>
        builder.Add("total_sold", totalSold);

    /// <summary>
    /// Filter items by type.
    /// </summary>
    public static T Type<T>(this T builder, BcProductType type)
        where T : IBcProductDeleteFilter =>
        builder.Add("type", type.ToValue());

    /// <summary>
    /// Filter items by upc.
    /// </summary>
    public static T Upc<T>(this T builder, string upc)
        where T : IBcProductSearchFilter =>
        builder.Add("upc", upc);

    /// <summary>
    /// Filter items by weight.
    /// </summary>
    public static T Weight<T>(this T builder, int weight)
        where T : IBcProductDeleteFilter =>
        builder.Add("weight", weight);
}