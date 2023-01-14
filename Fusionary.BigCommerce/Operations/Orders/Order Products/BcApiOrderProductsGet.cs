namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderProductsGet : BcRequestBuilder, IBcApiOperation
{
    public BcApiOrderProductsGet(IBcApi api) : base(api)
    { }

    public Task<BcResultData<List<BcOrderProduct>>> SendAsync(
        BcId orderId,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcOrderProduct>(orderId, cancellationToken);

    public async Task<BcResultData<List<T>>> SendAsync<T>(
        BcId orderId,
        CancellationToken cancellationToken = default
    ) =>
        await Api.GetDataAsync<List<T>>(
            BcEndpoint.OrderProductsV2(orderId),
            Filter,
            Options,
            cancellationToken
        );

    public Task<BcResultData<BcOrderProduct>> SendAsync(
        BcId orderId,
        BcId productId,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcOrderProduct>(orderId, productId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        BcId orderId,
        BcId productId,
        CancellationToken cancellationToken = default
    ) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.OrderProductsV2(orderId, productId),
            Filter,
            Options,
            cancellationToken
        );
}