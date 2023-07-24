namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryDeleteBulk : BcRequestBuilder,
    IBcApiOperation,
    IBcIdFilter,
    IBcIdRangeFilter,
    IBcCategoryFilter
{
    public BcApiCategoryDeleteBulk(IBcApi api) : base(api)
    { }

    public async Task<BcResult> SendAsync(CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.CategoryV3(),
            Filter,
            Options,
            cancellationToken
        );
}
