namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderGetWithConsignments : BcRequestBuilder, IBcApiOperation
{
    public BcApiOrderGetWithConsignments(IBcApi api) : base(api)
    {
    }
    
    public Task<BcResultData<BcOrderResponseFull>> SendAsync(
        BcId orderId,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcOrderResponseFull>(orderId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(BcId orderId, CancellationToken cancellationToken = default)
    {
        Filter.Add("include", "consignments");
        Filter.Add("consignment_structure", "object");

        return await Api.GetDataAsync<T>(
            BcEndpoint.OrdersV2(orderId),
            Filter,
            Options,
            cancellationToken
        );
    }
}