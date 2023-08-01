namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListRecordUpsert : BcRequestBuilder, IBcApiOperation
{
    public BcApiPriceListRecordUpsert(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcPriceList>> SendAsync(
        BcId priceListId,
        BcPriceListRecordUpsert priceListRecord,
        CancellationToken cancellationToken = default
    ) => Api.PostDataAsync<BcPriceList>(
        BcEndpoint.PriceListRecordsV3(priceListId),
        priceListRecord,
        Filter,
        Options,
        cancellationToken
    );
}
