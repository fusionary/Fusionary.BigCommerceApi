using Fusionary.BigCommerce.Types;

namespace Fusionary.BigCommerce.Operations;

public record BcProductUpdate : BcRequestBuilder<BcProductUpdate>
{
    public BcProductUpdate(IBigCommerceApi api) : base(api)
    { }

    /// <summary>
    /// Fields to include, in a comma-separated list. The ID and the specified fields will be returned.
    /// </summary>
    public BcProductUpdate IncludeFields(params string[] values) => Add("include_fields", values);

    public Task<BcDataResponse<BcObject>> SendAsync(
        int productId,
        BcProductBase product,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcObject, BcProductBase>(productId, product, cancellationToken);

    public Task<BcDataResponse<TResponse>> SendAsync<TResponse, TInput>(
        int productId,
        TInput product,
        CancellationToken cancellationToken
    ) =>
        Api.PutAsync<BcDataResponse<TResponse>>(BcEndpoint.ProductsV3(productId), product, Filter, cancellationToken);
}