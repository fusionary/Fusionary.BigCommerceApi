namespace Fusionary.BigCommerce.Operations;

public class BcApiProductGet(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcProductIncludeFilter
{
    public Task<BcResultData<BcProductFull>> SendAsync(int productId, CancellationToken cancellationToken = default) =>
        SendAsync<BcProductFull>(productId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(int productId, CancellationToken cancellationToken = default) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.ProductsV3(productId),
            Filter,
            Options,
            cancellationToken
        );
}