namespace Fusionary.BigCommerce.Operations;

public class BcProductGet : BcRequestBuilder,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcProductIncludeFilter
{
    public BcProductGet(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcProductFull>> SendAsync(int productId, CancellationToken cancellationToken) =>
        SendAsync<BcProductFull>(productId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(int productId, CancellationToken cancellationToken) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.ProductsV3(productId),
            Filter,
            Options,
            cancellationToken
        );
}