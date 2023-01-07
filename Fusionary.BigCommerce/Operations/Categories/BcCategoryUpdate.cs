namespace Fusionary.BigCommerce.Operations;

public class BcCategoryUpdate : BcRequestBuilder
{
    public BcCategoryUpdate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcOrderResponseFull>> SendAsync(
        BcCategory category,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcOrderResponseFull>(category.Id, category, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        int categoryId,
        object category,
        CancellationToken cancellationToken
    ) =>
        await Api.PutDataAsync<T>(
            BcEndpoint.CategoriesV3(categoryId),
            category,
            Filter,
            Options,
            cancellationToken
        );
}