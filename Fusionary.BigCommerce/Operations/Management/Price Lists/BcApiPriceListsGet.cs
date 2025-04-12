namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListsGet : BcRequestBuilder, IBcApiOperation
{
    public BcApiPriceListsGet(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcPriceList>> SendAsync(BcId priceListId, CancellationToken cancellationToken = default) =>
        SendAsync<BcPriceList>(priceListId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(BcId priceListId, CancellationToken cancellationToken = default) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.PriceListsV3(priceListId),
            Filter,
            Options,
            cancellationToken
        );
}