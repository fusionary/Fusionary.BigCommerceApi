namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderShippingGet(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<List<BcOrderShipping>>> SendAsync(
        BcId orderId,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcOrderShipping>(orderId, cancellationToken);

    public async Task<BcResultData<List<T>>> SendAsync<T>(
        BcId orderId,
        CancellationToken cancellationToken = default
    ) =>
        await Api.GetDataAsync<List<T>>(
            BcEndpoint.OrderShippingV2(orderId),
            Filter,
            Options,
            cancellationToken
        );
}
