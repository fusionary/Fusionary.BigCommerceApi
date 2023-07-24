namespace Fusionary.BigCommerce.Operations;

/// <summary>
/// Returns a list of product Custom Fields
/// </summary>
public class BcApiProductChannelAssignmentsGetList : BcRequestBuilder,
    IBcApiOperation,
    IBcProductChannelAssignmentSearchFilter,
    IBcPageableFilter
{
    public BcApiProductChannelAssignmentsGetList(IBcApi api) : base(api)
    { }

    public async Task<BcResultPaged<BcProductChannelAssignment>> SendAsync(CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<BcProductChannelAssignment>(
            BcEndpoint.ProductChannelAssignmentsV3(),
            Filter,
            Options,
            cancellationToken
        );
}
