namespace Fusionary.BigCommerce.Operations;

public record BcProductUpdate : BcRequestBuilder<BcProductUpdate>,
    IBcIncludeFieldsFilter
{
    public BcProductUpdate(IBigCommerceApi api) : base(api)
    { }

    public Task<BcDataResult<BcObject>> SendAsync(
        int productId,
        BcProductBase product,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcObject, BcProductBase>(productId, product, cancellationToken);

    public Task<BcDataResult<TResponse>> SendAsync<TResponse, TInput>(
        int productId,
        TInput product,
        CancellationToken cancellationToken
    ) =>
        Api.PutDataAsync<TResponse>(BcEndpoint.ProductsV3(productId), product, Filter, cancellationToken);
}