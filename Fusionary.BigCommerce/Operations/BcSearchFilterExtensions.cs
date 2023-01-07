namespace Fusionary.BigCommerce.Operations;

public static class BcSearchFilterExtensions
{
    /// <summary>
    /// Filter items by date_last_imported.
    /// </summary>
    public static T DateLastImported<T>(this T builder, string date, BcRange range = BcRange.None)
        where T : IBcRequestBuilder, IBcDateLastImportedFilter =>
        builder.Add(range.Apply("date_last_imported"), date);

    /// <summary>
    /// Filter items by date_last_imported.
    /// </summary>
    public static T DateLastImported<T>(this T builder, BcDateTime date, BcRange range = BcRange.None)
        where T : IBcRequestBuilder, IBcDateLastImportedFilter =>
        builder.Add(range.Apply("date_last_imported"), date);

    /// <summary>
    /// Filter items by date_modified.
    /// </summary>
    public static T DateModified<T>(this T builder, string date, BcRange range = BcRange.None)
        where T : IBcRequestBuilder, IBcDateModifiedFilter =>
        builder.Add(range.Apply("date_modified"), date);

    /// <summary>
    /// Filter items by date_modified.
    /// </summary>
    public static T DateModified<T>(this T builder, BcDateTime date, BcRange range = BcRange.None)
        where T : IBcRequestBuilder, IBcDateModifiedFilter =>
        builder.Add(range.Apply("date_modified"), date);

    /// <summary>
    /// Sort direction.
    /// </summary>
    public static T Direction<T>(this T builder, BcDirection direction)
        where T : IBcRequestBuilder, IBcDirectionFilter =>
        builder.Add("direction", direction.ToValue());

    /// <summary>
    /// Controls the number of items per page in a limited (paginated) list of results.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/docs/ZG9jOjIyMDYxMQ-filtering#pagination-and-limit
    /// </remarks>
    public static T Limit<T>(this T builder, int limit) where T : IBcRequestBuilder, IBcPageableFilter =>
        builder.Add("limit", limit);

    /// <summary>
    /// Filter items by name
    /// </summary>
    public static T Name<T>(this T builder, string name, BcModifier modifier = BcModifier.None)
        where T : IBcRequestBuilder, IBcNameFilter =>
        builder.Add(modifier.Apply("name"), name);

    /// <summary>
    /// Specifies the page number in a limited (paginated) list of results.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/docs/ZG9jOjIyMDYxMQ-filtering#pagination-and-limit
    /// </remarks>
    public static T Page<T>(this T builder, int page) where T : IBcRequestBuilder, IBcPageableFilter =>
        builder.Add("page", page);

    /// <summary>
    /// Filter items by page_title
    /// </summary>
    public static T PageTitle<T>(this T builder, string pageTitle, BcModifier modifier = BcModifier.None)
        where T : IBcRequestBuilder, IBcPageTitleFilter =>
        builder.Add(modifier.Apply("page_title"), pageTitle);
}