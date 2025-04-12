namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcExcludeFieldsFilter
{
    /// <summary>
    /// Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot
    /// be excluded.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/docs/ZG9jOjIyMDYxMQ-filtering#include-and-exclude-fields
    /// </remarks>
    public static T ExcludeFields<T>(this T builder, params string[] values)
        where T : IBcExcludeFieldsFilter =>
        builder.Add("exclude_fields", values);

    /// <summary>
    /// Fields to include, in a comma-separated list. The ID and the specified fields will be returned.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/docs/ZG9jOjIyMDYxMQ-filtering#include-and-exclude-fields
    /// </remarks>
    public static T IncludeFields<T>(this T builder, params string[] values)
        where T : IBcIncludeFieldsFilter =>
        builder.Add("include_fields", values);
}