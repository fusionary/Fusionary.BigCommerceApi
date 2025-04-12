namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcDateModifiedFilter
{
    /// <summary>
    /// Filter items by date_modified.
    /// </summary>
    public static T DateModified<T>(this T builder, string date, BcRange range = BcRange.None)
        where T : IBcDateModifiedFilter =>
        builder.Add(range.Apply("date_modified"), date);

    /// <summary>
    /// Filter items by date_modified.
    /// </summary>
    public static T DateModified<T>(this T builder, BcDateTime date, BcRange range = BcRange.None)
        where T : IBcDateModifiedFilter =>
        builder.Add(range.Apply("date_modified"), date);
}