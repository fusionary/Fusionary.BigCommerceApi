namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForProductChannelAssignmentSearchFilter
{
    /// <summary>
    /// Filter items by channels. For example, channel_id:in=12,14.
    /// </summary>
    public static T ChannelIn<T>(this T builder, params BcId[] categories)
        where T : IBcProductChannelAssignmentSearchFilter =>
        builder.Add("channel_id:in", categories.Select(x => x.Value));

    /// <summary>
    /// Filter items by products. For example, product_id:in=112,1324.
    /// </summary>
    public static T ProductIn<T>(this T builder, params BcId[] productIds)
        where T : IBcProductChannelAssignmentSearchFilter =>
        builder.Add("product_id:in", productIds.Select(x => x.Value));
}