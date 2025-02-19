namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderShippingCreate : BcRequestBuilder, IBcApiOperation
{
    public BcApiOrderShippingCreate(IBcApi api) : base(api)
    {
    }
    
    public async Task<BcResultData<BcOrderShipping>> SendAsync(
        int orderId,
        BcOrderShippingPost orderShipping,
        CancellationToken cancellationToken = default
    ) => await SendAsync<BcOrderShipping>(orderId, orderShipping, cancellationToken);
    
    public async Task<BcResultData<T>> SendAsync<T>(
        int orderId,
        BcOrderShippingPost orderShipping,
        CancellationToken cancellationToken = default
    ) => await Api.PostDataAsync<T>(
        BcEndpoint.OrderShipmentsV2(orderId),
        orderShipping,
        Filter,
        Options,
        cancellationToken
    );
}