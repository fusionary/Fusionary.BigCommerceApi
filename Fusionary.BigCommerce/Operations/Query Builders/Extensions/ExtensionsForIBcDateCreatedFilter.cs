namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcDateCreatedFilter
{
    /// <summary>
    /// Filter items by date_created.
    /// </summary>
    public static T DateCreated<T>(this T builder, string date, BcRange range = BcRange.None)
        where T : IBcDateCreatedFilter =>
        builder.Add(range.Apply("date_created"), date);

    /// <summary>
    /// Filter items by date_created.
    /// </summary>
    public static T DateCreated<T>(this T builder, BcDateTime date, BcRange range = BcRange.None)
        where T : IBcDateCreatedFilter =>
        builder.Add(range.Apply("date_created"), date);
}