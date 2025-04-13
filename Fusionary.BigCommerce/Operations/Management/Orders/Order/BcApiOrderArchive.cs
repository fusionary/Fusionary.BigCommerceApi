namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderArchive(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public async Task<BcResult> SendAsync(int orderId, CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.OrdersV2(orderId),
            Filter,
            Options,
            cancellationToken
        );
}