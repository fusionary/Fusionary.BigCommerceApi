namespace Fusionary.BigCommerce.Operations;

public record BcOrderMetafieldsGet : BcRequestBuilder<BcOrderMetafieldsGet>,
    IBcPageableFilter,
    IBcDirectionFilter
{
    public BcOrderMetafieldsGet(IBigCommerceApi api) : base(api)
    { }

    public Task<BcPagedResult<BcMetafieldBase>> SendAsync(int orderId, CancellationToken cancellationToken) =>
        SendAsync<BcMetafieldBase>(orderId, cancellationToken);

    public async Task<BcPagedResult<T>> SendAsync<T>(int orderId, CancellationToken cancellationToken) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.OrdersMetafieldsV3(orderId),
            Filter,
            cancellationToken
        );
}