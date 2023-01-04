namespace Fusionary.BigCommerce.Operations;

public record BcOrdersGet : BcRequestBuilder<BcOrdersGet>
{
    public BcOrdersGet(IBigCommerceApi api) : base(api)
    { }

    public Task<BcDataResult<BcOrderResponseFull>> SendAsync(int orderId, CancellationToken cancellationToken) =>
        SendAsync<BcOrderResponseFull>(orderId, cancellationToken);

    public async Task<BcDataResult<T>> SendAsync<T>(int orderId, CancellationToken cancellationToken) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.OrdersV2(orderId),
            Filter,
            cancellationToken
        );
}