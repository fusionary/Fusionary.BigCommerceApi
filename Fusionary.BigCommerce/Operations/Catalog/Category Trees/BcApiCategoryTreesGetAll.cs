namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryTreesGetAll(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcIdFilter,
    IBcChannelFilter
{
    public async Task<BcResultData<BcCategoryTree[]>> SendAsync(CancellationToken cancellationToken = default) =>
        await Api.GetDataAsync<BcCategoryTree[]>(
            BcEndpoint.CategoryTreesV3(),
            Filter,
            Options,
            cancellationToken
        );
}