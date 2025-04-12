namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryCreate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcCategory>> SendAsync(
        BcCategoryPost category,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcCategory>(category, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(object category, CancellationToken cancellationToken = default) =>
        await Api.PostDataAsync<T>(
            BcEndpoint.CategoryV3(),
            category,
            Filter,
            Options,
            cancellationToken
        );
}