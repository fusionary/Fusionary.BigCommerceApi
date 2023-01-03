using Fusionary.BigCommerce.Types;

namespace Fusionary.BigCommerce.Operations;

public record BcOrdersCreate: BcRequestBuilder<BcOrdersCreate>
{
    public BcOrdersCreate(IBigCommerceApi api) : base(api)
    { }
    
    public Task<BcDataResponse<BcOrderResponseFull>> SendAsync(BcOrderPost order, CancellationToken cancellationToken) =>
        SendAsync<BcOrderResponseFull>(order, cancellationToken);

    public async Task<BcDataResponse<T>> SendAsync<T>(object order, CancellationToken cancellationToken) =>
        await Api.PostAsync<BcDataResponse<T>>(
            BcEndpoint.OrdersV2(),
            order,
            Filter,
            cancellationToken
        );
}