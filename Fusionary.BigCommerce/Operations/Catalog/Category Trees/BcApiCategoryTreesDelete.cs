namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryTreesDelete : BcRequestBuilder,
    IBcApiOperation,
    IBcIdFilter
{
    public BcApiCategoryTreesDelete(IBcApi api) : base(api)
    { }

    public async Task<BcResult> SendAsync<T>(CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.CategoryTreesV3(),
            Filter,
            Options,
            cancellationToken
        );
}