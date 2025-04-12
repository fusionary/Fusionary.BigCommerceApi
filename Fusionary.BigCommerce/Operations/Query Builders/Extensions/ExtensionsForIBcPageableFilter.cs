namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcPageableFilter
{
    /// <summary>
    /// Controls the number of items per page in a limited (paginated) list of results.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/docs/ZG9jOjIyMDYxMQ-filtering#pagination-and-limit
    /// </remarks>
    public static T Limit<T>(this T builder, int limit)
        where T : IBcPageableFilter =>
        builder.Add("limit", limit);

    /// <summary>
    /// Specifies the page number in a limited (paginated) list of results.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/docs/ZG9jOjIyMDYxMQ-filtering#pagination-and-limit
    /// </remarks>
    public static T Page<T>(this T builder, int page)
        where T : IBcPageableFilter =>
        builder.Add("page", page);
}