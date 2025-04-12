namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryDeleteBulk(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcIdFilter,
    IBcIdRangeFilter,
    IBcCategoryFilter
{
    public async Task<BcResult> SendAsync(CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.CategoryV3(),
            Filter,
            Options,
            cancellationToken
        );
}