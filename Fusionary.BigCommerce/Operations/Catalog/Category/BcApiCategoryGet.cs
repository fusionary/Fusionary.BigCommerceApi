namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryGet : BcRequestBuilder,
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter
{
    public BcApiCategoryGet(IBcApi api) : base(api)
    { }

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