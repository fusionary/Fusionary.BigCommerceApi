namespace Fusionary.BigCommerce.Operations;

public static class BcChannelFilterExtensions
{
    /// <summary>
    /// Filter items by channel_id.
    /// </summary>
    public static T ChannelId<T>(this T builder, BcId channelId)
        where T : IBcIdFilter =>
        builder.Add("channel_id", channelId.Value);
}