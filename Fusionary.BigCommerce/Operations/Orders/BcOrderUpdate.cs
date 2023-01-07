namespace Fusionary.BigCommerce.Operations;

public class BcOrderUpdate : BcRequestBuilder
{
    public BcOrderUpdate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcOrderResponseFull>> SendAsync(
        BcOrderPut order,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcOrderResponseFull>(order.Id, order, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(int orderId, object order, CancellationToken cancellationToken) =>
        await Api.PutDataAsync<T>(
            BcEndpoint.OrdersV2(orderId),
            order,
            Filter,
            Options,
            cancellationToken
        );
}