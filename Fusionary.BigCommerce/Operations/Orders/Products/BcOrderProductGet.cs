namespace Fusionary.BigCommerce.Operations;

public class BcOrderProductGet : BcRequestBuilder
{
    public BcOrderProductGet(IBcApi api) : base(api)
    { }

    public Task<BcResultData<List<BcOrderProduct>>> SendAsync(object orderId, CancellationToken cancellationToken) =>
        SendAsync<BcOrderProduct>(orderId, cancellationToken);

    public async Task<BcResultData<List<T>>> SendAsync<T>(object orderId, CancellationToken cancellationToken) =>
        await Api.GetDataAsync<List<T>>(
            BcEndpoint.OrderProductsV2(orderId),
            Filter,
            Options,
            cancellationToken
        );

    public Task<BcResultData<BcOrderProduct>> SendAsync(
        object orderId,
        object productId,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcOrderProduct>(orderId, productId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        object orderId,
        object productId,
        CancellationToken cancellationToken
    ) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.OrderProductsV2(orderId, productId),
            Filter,
            Options,
            cancellationToken
        );
}