using Microsoft.AspNetCore.Http;

namespace Fusionary.BigCommerce;

public class BcCreateProduct : BcRequestBuilder<BcCreateProduct>
{
    public BcCreateProduct(IBigCommerceApi api, QueryString queryString) : base(api, queryString)
    { }

    public BcCreateProduct IncludeFields(params string[] fields) => Add("include_fields", string.Join(",", fields));

    public Task<BcResponse<BcObject>> SendAsync(BcProductBase product, CancellationToken cancellationToken) =>
        Api.PostAsync<BcResponse<BcObject>>(BcEndpoint.ProductsV3(), product, Filter, cancellationToken);

    public Task<BcResponse<TResponse>>
        SendAsync<TResponse, TInput>(TInput product, CancellationToken cancellationToken) =>
        Api.PostAsync<BcResponse<TResponse>>(BcEndpoint.ProductsV3(), product, Filter, cancellationToken);
}