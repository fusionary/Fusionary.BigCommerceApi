namespace Fusionary.BigCommerce.Operations;

public static class BcFieldFilterExtensions
{
    /// <summary>
    /// Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot
    /// be excluded.
    /// </summary>
    public static T ExcludeFields<T>(this T builder, params string[] values)
        where T : BcRequestBuilder<T>, IBcExcludeFieldsFilter =>
        builder.Add("exclude_fields", values);

    /// <summary>
    /// Fields to include, in a comma-separated list. The ID and the specified fields will be returned.
    /// </summary>
    public static T IncludeFields<T>(this T builder, params string[] values)
        where T : BcRequestBuilder<T>, IBcIncludeFieldsFilter =>
        builder.Add("include_fields", values);
}