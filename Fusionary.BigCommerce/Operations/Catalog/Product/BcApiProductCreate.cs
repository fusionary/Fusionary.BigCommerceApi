namespace Fusionary.BigCommerce.Operations;

public class BcApiProductCreate : BcRequestBuilder, IBcApiOperation,
    IBcIncludeFieldsFilter
{
    public BcApiProductCreate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcProductFull>> SendAsync(
        BcProductPost product,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductFull>(product, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse>(
        object product,
        CancellationToken cancellationToken = default
    ) =>
        Api.PostDataAsync<TResponse>(BcEndpoint.ProductsV3(), product, Filter, Options, cancellationToken);
}
