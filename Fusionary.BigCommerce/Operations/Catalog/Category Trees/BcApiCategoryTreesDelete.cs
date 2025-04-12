namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryTreesDelete(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcIdFilter
{
    public async Task<BcResult> SendAsync(CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.CategoryTreesV3(),
            Filter,
            Options,
            cancellationToken
        );
}