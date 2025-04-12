namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryGet(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter
{
    public Task<BcResultData<BcCategory>> SendAsync(BcId categoryId, CancellationToken cancellationToken = default) =>
        SendAsync<BcCategory>(categoryId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(BcId categoryId, CancellationToken cancellationToken = default) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.CategoryV3(categoryId),
            Filter,
            Options,
            cancellationToken
        );
}