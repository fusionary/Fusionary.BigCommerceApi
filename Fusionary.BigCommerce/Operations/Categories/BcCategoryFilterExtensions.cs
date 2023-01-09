namespace Fusionary.BigCommerce.Operations;

public static class BcCategoryFilterExtensions
{
    /// <summary>
    /// Filter items based on whether the product is currently visible on the storefront.
    /// </summary>
    public static T IsVisible<T>(this T builder, bool isVisible)
        where T : IBcCategoryFilter =>
        builder.Add("is_visible", isVisible);

    /// <summary>
    /// Filter items by keywords found in the name or sku fields
    /// </summary>
    public static T Keyword<T>(this T builder, string keyword)
        where T : IBcCategoryFilter =>
        builder.Add("keyword", keyword);

    /// <summary>
    /// Filter items by name.
    /// </summary>
    public static T Name<T>(this T builder, params string[] names)
        where T : IBcCategoryFilter =>
        builder.Add(names.Length > 1 ? "name:like" : "name", names);

    /// <summary>
    /// Filter items by name.
    /// </summary>
    public static T PageTitle<T>(this T builder, params string[] pageTiles)
        where T : IBcCategoryFilter =>
        builder.Add(
            pageTiles.Length > 1 ? "page_title:like" : "page_title",
            pageTiles
        );

    /// <summary>
    /// Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.
    /// </summary>
    public static T ParentId<T, TValue>(this T builder, object parentId)
        where T : IBcCategoryFilter =>
        builder.Add("parent_id", parentId);

    /// <summary>
    /// Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.
    /// </summary>
    public static T ParentId<T>(this T builder, IEnumerable<object> parentIds, BcModifier modifier)
        where T : IBcCategoryFilter =>
        builder.Add(modifier.Apply("parent_id"), parentIds);
}