namespace Fusionary.BigCommerce.Operations;

public class BcApiProductChannelAssignmentsDelete : BcRequestBuilder, IBcApiOperation
{
    public BcApiProductChannelAssignmentsDelete(IBcApi api) : base(api)
    { }

    public Task<BcResult> SendAsync(
        BcProductChannelAssignment channelAssignment,
        CancellationToken cancellationToken = default
    ) =>
        Api.DeleteAsync(
            BcEndpoint.ProductChannelAssignmentsV3(),
            Filter
                .Add("product_id", channelAssignment.ProductId.Value)
                .Add("channel_id", channelAssignment.ChannelId.Value),
            Options,
            cancellationToken
        );
}