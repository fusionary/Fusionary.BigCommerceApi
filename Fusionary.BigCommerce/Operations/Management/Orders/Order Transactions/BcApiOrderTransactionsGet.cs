namespace Fusionary.BigCommerce.Operations.Order_Transactions;

public class BcApiOrderTransactionsGet(IBcApi api) : BcRequestBuilder(api), IBcApiOperation, IBcPageableFilter
{
    public Task<BcResultPaged<BcOrderTransaction>> SendAsync(
        BcId orderId,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcOrderTransaction>(orderId, cancellationToken);
    
    public async Task<BcResultPaged<T>> SendAsync<T>(BcId orderId, CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.OrderTransactionsV3(orderId),
            Filter,
            Options,
            cancellationToken
        );
}