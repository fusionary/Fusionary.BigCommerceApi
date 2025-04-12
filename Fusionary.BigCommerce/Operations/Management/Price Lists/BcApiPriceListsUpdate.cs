namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListsUpdate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcPriceList>> SendAsync(
        BcId priceListId,
        BcPriceListPut priceList,
        CancellationToken cancellationToken = default
    ) => Api.PutDataAsync<BcPriceList>(
        BcEndpoint.PriceListsV3(priceListId),
        priceList,
        Filter,
        Options,
        cancellationToken
    );
}