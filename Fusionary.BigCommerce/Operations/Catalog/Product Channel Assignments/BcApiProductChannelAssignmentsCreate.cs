namespace Fusionary.BigCommerce.Operations;

public class BcApiProductChannelAssignmentsCreate : BcRequestBuilder, IBcApiOperation
{
    public BcApiProductChannelAssignmentsCreate(IBcApi api) : base(api)
    { }

    public Task<BcResult> SendAsync(
        BcProductChannelAssignment channelAssignment,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync(channelAssignment.AsEnumerable(), cancellationToken);

    public async Task<BcResult> SendAsync(
        IEnumerable<BcProductChannelAssignment> channelAssignments,
        CancellationToken cancellationToken = default
    ) =>
        await Api.PutDataAsync<object?>(
            BcEndpoint.ProductChannelAssignmentsV3(),
            channelAssignments,
            Filter,
            Options,
            cancellationToken
        );
}