namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcCategoryFilter
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
}