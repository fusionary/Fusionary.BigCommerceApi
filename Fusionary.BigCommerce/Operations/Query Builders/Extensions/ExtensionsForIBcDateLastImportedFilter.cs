namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcDateLastImportedFilter
{
    /// <summary>
    /// Filter items by date_last_imported.
    /// </summary>
    public static T DateLastImported<T>(this T builder, string date, BcRange range = BcRange.None)
        where T : IBcDateLastImportedFilter =>
        builder.Add(range.Apply("date_last_imported"), date);

    /// <summary>
    /// Filter items by date_last_imported.
    /// </summary>
    public static T DateLastImported<T>(this T builder, BcDateTime date, BcRange range = BcRange.None)
        where T : IBcDateLastImportedFilter =>
        builder.Add(range.Apply("date_last_imported"), date);
}