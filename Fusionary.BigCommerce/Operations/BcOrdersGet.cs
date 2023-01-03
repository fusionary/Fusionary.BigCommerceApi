using Fusionary.BigCommerce.Types;

namespace Fusionary.BigCommerce.Operations;

public record BcOrdersGet : BcRequestBuilder<BcOrdersGet>
{
    public BcOrdersGet(IBigCommerceApi api) : base(api)
    { }

    public Task<BcOrderResponseFull> SendAsync(int orderId, CancellationToken cancellationToken) =>
        SendAsync<BcOrderResponseFull>(orderId, cancellationToken);

    public async Task<T> SendAsync<T>(int orderId, CancellationToken cancellationToken) =>
        await Api.GetAsync<T>(
            BcEndpoint.OrdersV2(orderId),
            Filter,
            cancellationToken
        );
}