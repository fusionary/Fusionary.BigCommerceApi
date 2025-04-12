namespace Fusionary.BigCommerce.Operations;

/// <summary>
/// Returns a list of product Custom Fields
/// </summary>
public class BcApiProductChannelAssignmentsGetList(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcProductChannelAssignmentSearchFilter,
    IBcPageableFilter
{
    public async Task<BcResultPaged<BcProductChannelAssignment>> SendAsync(
        CancellationToken cancellationToken = default
    ) =>
        await Api.GetPagedAsync<BcProductChannelAssignment>(
            BcEndpoint.ProductChannelAssignmentsV3(),
            Filter,
            Options,
            cancellationToken
        );
}