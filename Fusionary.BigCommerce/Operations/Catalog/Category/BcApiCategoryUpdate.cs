namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryUpdate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcCategory>> SendAsync(
        BcCategory category,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcCategory>(category.Id, category, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        BcId categoryId,
        object category,
        CancellationToken cancellationToken = default
    ) =>
        await Api.PutDataAsync<T>(
            BcEndpoint.CategoryV3(categoryId),
            category,
            Filter,
            Options,
            cancellationToken
        );
}