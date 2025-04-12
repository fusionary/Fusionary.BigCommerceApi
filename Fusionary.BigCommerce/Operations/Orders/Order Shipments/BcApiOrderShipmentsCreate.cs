namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderShipmentsCreate : BcRequestBuilder, IBcApiOperation
{
    public BcApiOrderShipmentsCreate(IBcApi api) : base(api)
    { }

    public async Task<BcResultData<BcOrderShipping>> SendAsync(
        int orderId,
        BcOrderShipmentsPost orderShipments,
        CancellationToken cancellationToken = default
    ) => await SendAsync<BcOrderShipping>(orderId, orderShipments, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        int orderId,
        BcOrderShipmentsPost orderShipments,
        CancellationToken cancellationToken = default
    ) => await Api.PostDataAsync<T>(
        BcEndpoint.OrderShipmentsV2(orderId),
        orderShipments,
        Filter,
        Options,
        cancellationToken
    );
}