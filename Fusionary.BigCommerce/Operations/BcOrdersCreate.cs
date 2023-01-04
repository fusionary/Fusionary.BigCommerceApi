namespace Fusionary.BigCommerce.Operations;

public record BcOrdersCreate : BcRequestBuilder<BcOrdersCreate>
{
    public BcOrdersCreate(IBigCommerceApi api) : base(api)
    { }

    public Task<BcDataResult<BcOrderResponseFull>> SendAsync(
        BcOrderPost order,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcOrderResponseFull>(order, cancellationToken);

    public async Task<BcDataResult<T>> SendAsync<T>(object order, CancellationToken cancellationToken) =>
        await Api.PostDataAsync<T>(
            BcEndpoint.OrdersV2(),
            order,
            Filter,
            cancellationToken
        );
}