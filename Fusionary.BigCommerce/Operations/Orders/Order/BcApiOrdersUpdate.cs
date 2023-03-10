namespace Fusionary.BigCommerce.Operations;

public class BcApiOrdersUpdate : BcRequestBuilder, IBcApiOperation
{
    public BcApiOrdersUpdate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcOrderResponseFull>> SendAsync(
        BcId orderId,
        BcOrderPut order,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcOrderResponseFull>(orderId, order, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        int orderId,
        object order,
        CancellationToken cancellationToken = default
    ) =>
        await Api.PutDataAsync<T>(
            BcEndpoint.OrdersV2(orderId),
            order,
            Filter,
            Options,
            cancellationToken
        );
}