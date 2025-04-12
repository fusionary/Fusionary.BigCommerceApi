namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListsCreate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcPriceList>> SendAsync(
        BcPriceListPost priceList,
        CancellationToken cancellationToken = default
    ) => Api.PostDataAsync<BcPriceList>(
        BcEndpoint.PriceListsV3(),
        priceList,
        Filter,
        Options,
        cancellationToken
    );
}