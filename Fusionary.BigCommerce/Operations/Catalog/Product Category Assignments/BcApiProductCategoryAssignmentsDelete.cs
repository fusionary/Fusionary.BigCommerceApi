namespace Fusionary.BigCommerce.Operations;

public class BcApiProductCategoryAssignmentsDelete : BcRequestBuilder, IBcApiOperation
{
    public BcApiProductCategoryAssignmentsDelete(IBcApi api) : base(api)
    { }

    public Task<BcResult> SendAsync(
        BcProductCategoryAssignment categoryAssignment,
        CancellationToken cancellationToken = default
    ) =>
        Api.DeleteAsync(
            BcEndpoint.ProductCategoryAssignmentsV3(),
            Filter
                .Add("product_id", categoryAssignment.ProductId.Value)
                .Add("category_id", categoryAssignment.CategoryId.Value),
            Options,
            cancellationToken
        );
}