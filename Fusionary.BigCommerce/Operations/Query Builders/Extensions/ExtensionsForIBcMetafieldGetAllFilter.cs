namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcMetafieldGetAllFilter
{
    /// <summary>
    /// Filter based on a metafield key.
    /// </summary>
    public static T Key<T>(this T builder, string value) where T : IBcMetafieldGetAllFilter =>
        builder.Add("key", value);

    /// <summary>
    /// Filter based on a metafield namespace.
    /// </summary>
    public static T Namespace<T>(this T builder, string value)
        where T : IBcMetafieldGetAllFilter => builder.Add("namespace", value);
}