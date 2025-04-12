namespace Fusionary.BigCommerce.Operations;

public class BcApiProductCategoryAssignmentsCreate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResult> SendAsync(
        BcProductCategoryAssignment categoryAssignment,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync(categoryAssignment.AsEnumerable(), cancellationToken);

    public async Task<BcResult> SendAsync(
        IEnumerable<BcProductCategoryAssignment> categoryAssignments,
        CancellationToken cancellationToken = default
    ) =>
        await Api.PostDataAsync<object?>(
            BcEndpoint.ProductCategoryAssignmentsV3(),
            categoryAssignments,
            Filter,
            Options,
            cancellationToken
        );
}