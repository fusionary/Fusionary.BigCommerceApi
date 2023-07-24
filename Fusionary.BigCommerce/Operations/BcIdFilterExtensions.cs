namespace Fusionary.BigCommerce.Operations;

public static class BcIdFilterExtensions
{
    /// <summary>
    /// Filter items by id.
    /// </summary>
    public static T Id<T>(this T builder, BcId id)
        where T : IBcIdFilter =>
        builder.Add("id", id.Value);

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
