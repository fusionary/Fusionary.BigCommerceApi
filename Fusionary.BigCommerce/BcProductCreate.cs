namespace Fusionary.BigCommerce;

public class BcProductCreate : BcRequestBuilder<BcProductCreate>
{
    public BcProductCreate(IBigCommerceApi api) : base(api)
    { }

    public BcProductCreate IncludeFields(params string[] fields) => Add("include_fields", string.Join(",", fields));

    public Task<BcDataResponse<BcObject>> SendAsync(
        BcProductBase product, 
        CancellationToken cancellationToken) =>
        Api.PostAsync<BcDataResponse<BcObject>>(BcEndpoint.ProductsV3(), product, Filter, cancellationToken);

    public Task<BcDataResponse<TResponse>> SendAsync<TResponse, TInput>(
        TInput product, 
        CancellationToken cancellationToken) =>
        Api.PostAsync<BcDataResponse<TResponse>>(BcEndpoint.ProductsV3(), product, Filter, cancellationToken);
}