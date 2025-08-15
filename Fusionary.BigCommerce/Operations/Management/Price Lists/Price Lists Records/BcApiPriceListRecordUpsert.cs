namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListRecordUpsert(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultDataBatch<object>> SendAsync(
        BcId priceListId,
        IEnumerable<BcPriceListRecordUpsert> priceListRecord,
        CancellationToken cancellationToken = default
    ) => Api.PutDataBatchAsync<object>(
        BcEndpoint.PriceListRecordsV3(priceListId),
        priceListRecord,
        Filter,
        Options,
        cancellationToken
    );
}