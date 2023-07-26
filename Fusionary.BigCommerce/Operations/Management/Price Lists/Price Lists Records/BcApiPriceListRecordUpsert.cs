namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListRecordUpsert : BcRequestBuilder, IBcApiOperation
{
    public BcApiPriceListRecordUpsert(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcPriceList>> SendAsync(
        BcId priceListId,
        BcPriceListRecordPut priceList,
        CancellationToken cancellationToken = default
    ) => Api.PostDataAsync<BcPriceList>(
        BcEndpoint.PriceListsV3(priceListId),
        priceList,
        Filter,
        Options,
        cancellationToken
    );
}
