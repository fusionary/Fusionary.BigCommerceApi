namespace Fusionary.BigCommerce.Operations;

public class BcApiProductsUpdate(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcIncludeFieldsFilter
{
    public Task<BcResultData<BcProductFull>> SendAsync(
        BcProductFull product,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductFull, BcProductFull>(product.Id, product, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse, TInput>(
        int productId,
        TInput product,
        CancellationToken cancellationToken = default
    ) =>
        Api.PutDataAsync<TResponse>(BcEndpoint.ProductsV3(productId), product, Filter, Options, cancellationToken);
}