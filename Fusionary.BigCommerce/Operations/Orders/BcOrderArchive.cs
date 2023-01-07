namespace Fusionary.BigCommerce.Operations;

public class BcOrderArchive : BcRequestBuilder
{
    public BcOrderArchive(IBcApi api) : base(api)
    { }

    public async Task<BcResult> SendAsync<TProduct>(int orderId, CancellationToken cancellationToken) =>
        await Api.DeleteAsync(
            BcEndpoint.OrdersV2(orderId),
            Filter,
            Options,
            cancellationToken
        );
}