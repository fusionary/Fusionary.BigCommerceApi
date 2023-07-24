namespace Fusionary.BigCommerce.Operations;

/// <summary>
/// Returns a list of product Custom Fields
/// </summary>
public class BcApiProductCategoryAssignmentsGetList : BcRequestBuilder,
    IBcApiOperation,
    IBcProductCategoryAssignmentSearchFilter,
    IBcPageableFilter
{
    public BcApiProductCategoryAssignmentsGetList(IBcApi api) : base(api)
    { }

    public async Task<BcResultPaged<BcProductCategoryAssignment>> SendAsync(CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<BcProductCategoryAssignment>(
            BcEndpoint.ProductCategoryAssignmentsV3(),
            Filter,
            Options,
            cancellationToken
        );
}
