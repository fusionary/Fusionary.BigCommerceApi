namespace Fusionary.BigCommerce.Operations;

public class BcApiProductCategoryAssignmentsCreate : BcRequestBuilder, IBcApiOperation
{
    public BcApiProductCategoryAssignmentsCreate(IBcApi api) : base(api)
    { }

    public Task<BcResult> SendAsync(
        BcProductCategoryAssignment categoryAssignment,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync(categoryAssignment.AsEnumerable(), cancellationToken);

    public async Task<BcResult> SendAsync(
        IEnumerable<BcProductCategoryAssignment> categoryAssignments,
        CancellationToken cancellationToken = default
    )
    {
        return await Api.PostDataAsync<object?>(
          BcEndpoint.ProductCategoryAssignmentsV3(),
          categoryAssignments,
          Filter,
          Options,
          cancellationToken
      );
    }
}
