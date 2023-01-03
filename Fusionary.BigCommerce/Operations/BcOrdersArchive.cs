namespace Fusionary.BigCommerce.Operations;

public record BcOrdersArchive: BcRequestBuilder<BcOrdersArchive>
{
    public BcOrdersArchive(IBigCommerceApi api) : base(api)
    { }
    
    public async Task<bool> SendAsync<TProduct>(int orderId, CancellationToken cancellationToken) =>
        await Api.DeleteAsync(
            BcEndpoint.OrdersV2(orderId),
            Filter,
            cancellationToken
        );
}