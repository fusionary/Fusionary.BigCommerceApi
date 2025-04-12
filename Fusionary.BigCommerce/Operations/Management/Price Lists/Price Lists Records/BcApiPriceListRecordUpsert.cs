namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListRecordUpsert : BcRequestBuilder, IBcApiOperation
{
    public BcApiPriceListRecordUpsert(IBcApi api) : base(api)
    { }

    public Task<BcResultData<object>> SendAsync(
        BcId priceListId,
        IEnumerable<BcPriceListRecordUpsert> priceListRecord,
        CancellationToken cancellationToken = default
    ) => Api.PutDataAsync<object>(
        BcEndpoint.PriceListRecordsV3(priceListId),
        priceListRecord,
        Filter,
        Options,
        cancellationToken
    );
}