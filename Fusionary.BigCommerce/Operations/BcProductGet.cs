namespace Fusionary.BigCommerce.Operations;

public record BcProductGet : BcRequestBuilder<BcProductGet>,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcProductIncludeFilter
{
    public BcProductGet(IBigCommerceApi api) : base(api)
    { }

    public Task<BcDataResult<BcObject>> SendAsync(int productId, CancellationToken cancellationToken) =>
        SendAsync<BcObject>(productId, cancellationToken);

    public async Task<BcDataResult<T>> SendAsync<T>(int productId, CancellationToken cancellationToken) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.ProductsV3(productId),
            Filter,
            cancellationToken
        );
}