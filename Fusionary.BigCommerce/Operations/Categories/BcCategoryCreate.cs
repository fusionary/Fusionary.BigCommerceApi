namespace Fusionary.BigCommerce.Operations;

public class BcCategoryCreate : BcRequestBuilder
{
    public BcCategoryCreate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcOrderResponseFull>> SendAsync(
        BcCategory category,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcOrderResponseFull>(category, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(object category, CancellationToken cancellationToken) =>
        await Api.PostDataAsync<T>(
            BcEndpoint.CategoriesV3(),
            category,
            Filter,
            Options,
            cancellationToken
        );
}