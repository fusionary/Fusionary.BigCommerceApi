namespace Fusionary.BigCommerce.Operations;

public class BcProductUpdate : BcRequestBuilder,
    IBcIncludeFieldsFilter
{
    public BcProductUpdate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcProductFull>> SendAsync(
        BcProductFull product,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcProductFull, BcProductFull>(product.Id, product, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse, TInput>(
        int productId,
        TInput product,
        CancellationToken cancellationToken
    ) =>
        Api.PutDataAsync<TResponse>(BcEndpoint.ProductsV3(productId), product, Filter, Options, cancellationToken);
}