namespace Fusionary.BigCommerce.Operations;

public record BcOrderProductGet : BcRequestBuilder<BcOrderProductGet>
{
    public BcOrderProductGet(IBigCommerceApi api) : base(api)
    { }

    public Task<BcDataResult<List<BcOrderProduct>>> SendAsync(object orderId, CancellationToken cancellationToken) =>
        SendAsync<BcOrderProduct>(orderId, cancellationToken);

    public async Task<BcDataResult<List<T>>> SendAsync<T>(object orderId, CancellationToken cancellationToken) =>
        await Api.GetDataAsync<List<T>>(
            BcEndpoint.OrderProductsV2(orderId),
            Filter,
            cancellationToken
        );

    public Task<BcDataResult<BcOrderProduct>> SendAsync(
        object orderId,
        object productId,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcOrderProduct>(orderId, productId, cancellationToken);

    public async Task<BcDataResult<T>> SendAsync<T>(
        object orderId,
        object productId,
        CancellationToken cancellationToken
    ) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.OrderProductsV2(orderId, productId),
            Filter,
            cancellationToken
        );
}