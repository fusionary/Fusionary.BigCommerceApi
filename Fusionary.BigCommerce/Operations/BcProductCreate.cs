namespace Fusionary.BigCommerce.Operations;

public record BcProductCreate : BcRequestBuilder<BcProductCreate>,
    IBcIncludeFieldsFilter
{
    public BcProductCreate(IBigCommerceApi api) : base(api)
    { }

    public Task<BcDataResult<BcProductFull>> SendAsync(
        BcProductFull product,
        CancellationToken cancellationToken
    ) =>
        Api.PostDataAsync<BcProductFull>(BcEndpoint.ProductsV3(), product, Filter, cancellationToken);

    public Task<BcDataResult<TResponse>> SendAsync<TResponse, TInput>(
        TInput product,
        CancellationToken cancellationToken
    ) =>
        Api.PostDataAsync<TResponse>(BcEndpoint.ProductsV3(), product, Filter, cancellationToken);
}