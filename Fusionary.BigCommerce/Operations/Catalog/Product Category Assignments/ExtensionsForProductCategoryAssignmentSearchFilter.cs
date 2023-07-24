namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForProductCategoryAssignmentSearchFilter
{
    /// <summary>
    /// Filter items by categories. For example, category_id:in=12,14.
    /// </summary>
    public static T CategoryIn<T>(this T builder, params BcId[] categories)
        where T : IBcProductCategoryAssignmentSearchFilter =>
        builder.Add("category_id:in", categories.Select(x => x.Value));

    /// <summary>
    /// Filter items by products. For example, product_id:in=112,1324.
    /// </summary>
    public static T ProductIn<T>(this T builder, params BcId[] productIds)
        where T : IBcProductCategoryAssignmentSearchFilter =>
        builder.Add("product_id:in", productIds.Select(x => x.Value));
}
