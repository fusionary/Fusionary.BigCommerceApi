namespace Fusionary.BigCommerce.Operations;

public class BcApiOrdersGet : BcRequestBuilder, IBcApiOperation
{
    public BcApiOrdersGet(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcOrderResponseFull>> SendAsync(
        BcId orderId,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcOrderResponseFull>(orderId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(BcId orderId, CancellationToken cancellationToken = default) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.OrdersV2(orderId),
            Filter,
            Options,
            cancellationToken
        );
}