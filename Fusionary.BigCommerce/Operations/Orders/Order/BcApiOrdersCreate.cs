namespace Fusionary.BigCommerce.Operations;

public class BcApiOrdersCreate : BcRequestBuilder, IBcApiOperation
{
    public BcApiOrdersCreate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcOrderResponseFull>> SendAsync(
        BcOrderPost order,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcOrderResponseFull>(order, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(object order, CancellationToken cancellationToken = default) =>
        await Api.PostDataAsync<T>(
            BcEndpoint.OrdersV2(),
            order,
            Filter,
            Options,
            cancellationToken
        );
}