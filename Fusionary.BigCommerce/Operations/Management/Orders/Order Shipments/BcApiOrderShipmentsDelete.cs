namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderShipmentsDelete(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public async Task<BcResult> SendAsync(
        BcId orderId,
        BcId shipmentId,
        CancellationToken cancellationToken = default
    ) => await Api.DeleteAsync(
        BcEndpoint.OrderShipmentsV2(orderId, shipmentId),
        Filter,
        Options,
        cancellationToken
    );
}

