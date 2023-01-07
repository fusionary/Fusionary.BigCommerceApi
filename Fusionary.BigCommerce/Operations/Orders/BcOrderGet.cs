namespace Fusionary.BigCommerce.Operations;

public class BcOrderGet : BcRequestBuilder
{
    public BcOrderGet(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcOrderResponseFull>> SendAsync(object orderId, CancellationToken cancellationToken) =>
        SendAsync<BcOrderResponseFull>(orderId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(object orderId, CancellationToken cancellationToken) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.OrdersV2(orderId),
            Filter,
            Options,
            cancellationToken
        );
}