namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForBcProductFilters
{
    /// <summary>
    /// Sub-resources to include on a product, in a comma-separated list.
    /// <para>
    /// * If options or modifiers is used, results are limited to 10 per page.
    /// </para>
    /// </summary>
    public static T Include<T>(this T builder, params string[] values)
        where T : IBcProductIncludeFilter
        => builder.Add("include", values);

    /// <summary>
    /// Sub-resources to include on a product, in a comma-separated list.
    /// <para>
    /// * If options or modifiers is used, results are limited to 10 per page.
    /// </para>
    /// </summary>
    public static T Include<T>(this T builder, params BcProductInclude[] values)
        where T : IBcProductIncludeFilter
        => builder.Add("include", values.Select(x => x.ToValue()));
}
