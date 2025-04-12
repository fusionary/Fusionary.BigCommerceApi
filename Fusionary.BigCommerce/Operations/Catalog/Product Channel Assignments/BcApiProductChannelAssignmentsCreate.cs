namespace Fusionary.BigCommerce.Operations;

public class BcApiProductChannelAssignmentsCreate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
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