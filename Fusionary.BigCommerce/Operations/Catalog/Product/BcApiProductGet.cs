namespace Fusionary.BigCommerce.Operations;

public class BcApiProductGet : BcRequestBuilder,
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcProductIncludeFilter
{
    public BcApiProductGet(IBcApi api) : base(api)
    { }

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