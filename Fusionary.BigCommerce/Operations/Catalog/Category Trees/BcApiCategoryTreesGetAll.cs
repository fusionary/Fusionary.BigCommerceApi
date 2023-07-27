namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryTreesGetAll : BcRequestBuilder,
    IBcApiOperation,
    IBcIdFilter,
    IBcChannelFilter
{
    public BcApiCategoryTreesGetAll(IBcApi api) : base(api)
    { }

    public async Task<BcResultData<BcCategoryTree[]>> SendAsync(CancellationToken cancellationToken = default) =>
        await Api.GetDataAsync<BcCategoryTree[]>(
            BcEndpoint.CategoryTreesV3(),
            Filter,
            Options,
            cancellationToken
        );
}
