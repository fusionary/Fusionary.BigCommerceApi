namespace Fusionary.BigCommerce.Operations;

public class BcProductCreate : BcRequestBuilder,
    IBcIncludeFieldsFilter
{
    public BcProductCreate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcProductFull>> SendAsync(
        BcProductFull product,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcProductFull>(product, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse>(
        object product,
        CancellationToken cancellationToken
    ) =>
        Api.PostDataAsync<TResponse>(BcEndpoint.ProductsV3(), product, Filter, Options, cancellationToken);
}