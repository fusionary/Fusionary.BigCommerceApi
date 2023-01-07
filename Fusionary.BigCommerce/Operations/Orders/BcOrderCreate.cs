namespace Fusionary.BigCommerce.Operations;

public class BcOrderCreate : BcRequestBuilder
{
    public BcOrderCreate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcOrderResponseFull>> SendAsync(
        BcOrderPost order,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcOrderResponseFull>(order, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(object order, CancellationToken cancellationToken) =>
        await Api.PostDataAsync<T>(
            BcEndpoint.OrdersV2(),
            order,
            Filter,
            Options,
            cancellationToken
        );
}