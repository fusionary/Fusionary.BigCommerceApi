namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderShipmentsGet(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public async Task<BcResultData<List<BcOrderShipments>>> SendAsync(
        BcId orderId,
        CancellationToken cancellationToken = default
    ) => await SendAsync<BcOrderShipments>(orderId, cancellationToken);

    public async Task<BcResultData<List<T>>> SendAsync<T>(
        int orderId,
        CancellationToken cancellationToken = default
    ) => await Api.GetDataAsync<List<T>>(
        BcEndpoint.OrderShipmentsV2(orderId),
        Filter,
        Options,
        cancellationToken
    );
}