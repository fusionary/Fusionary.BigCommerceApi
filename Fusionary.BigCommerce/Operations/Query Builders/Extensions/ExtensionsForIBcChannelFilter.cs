namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForIBcChannelFilter
{
    /// <summary>
    /// Filter items by channel_id.
    /// </summary>
    public static T ChannelId<T>(this T builder, BcId channelId)
        where T : IBcChannelFilter =>
        builder.Add("channel_id", channelId.Value);
}