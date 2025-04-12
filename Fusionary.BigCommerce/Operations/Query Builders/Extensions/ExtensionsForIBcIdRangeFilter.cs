namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcIdRangeFilter
{
    /// <summary>
    /// Filter items by ids.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/docs/ZG9jOjIyMDYxMQ-filtering
    /// </remarks>
    public static T Id<T>(this T builder, IEnumerable<BcId> id, BcModifier modifier)
        where T : IBcIdRangeFilter =>
        builder.Add(modifier.Apply("id"), id.Select(x => x.Value));
}