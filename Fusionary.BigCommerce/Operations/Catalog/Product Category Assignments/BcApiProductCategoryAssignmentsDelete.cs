namespace Fusionary.BigCommerce.Operations;

public class BcApiProductCategoryAssignmentsDelete(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
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