namespace Fusionary.BigCommerce.Operations;

public class BcCategoryGet : BcRequestBuilder,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter
{
    public BcCategoryGet(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcCategory>> SendAsync(object categoryId, CancellationToken cancellationToken) =>
        SendAsync<BcCategory>(categoryId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(object categoryId, CancellationToken cancellationToken) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.CategoriesV3(categoryId),
            Filter,
            Options,
            cancellationToken
        );
}