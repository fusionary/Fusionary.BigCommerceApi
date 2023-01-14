namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderArchive : BcRequestBuilder, IBcApiOperation
{
    public BcApiOrderArchive(IBcApi api) : base(api)
    { }

    public async Task<BcResult> SendAsync<TProduct>(int orderId, CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.OrdersV2(orderId),
            Filter,
            Options,
            cancellationToken
        );
}