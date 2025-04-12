namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListsUpdate : BcRequestBuilder, IBcApiOperation
{
    public BcApiPriceListsUpdate(IBcApi api) : base(api)
    { }

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