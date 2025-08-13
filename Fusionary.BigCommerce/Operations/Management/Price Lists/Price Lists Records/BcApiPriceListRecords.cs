namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListRecords(IBcApi api) : IBcApiOperation
{
    public BcApiPriceListRecordUpsert Upsert() => new(api);

    public BcApiPriceListRecordGetAll GetAll() => new(api);

    public BcApiPriceListRecordsDeleteAll DeleteAll() => new(api);
}

public class BcApiPriceListRecordsDeleteAll(IBcApi api) : BcRequestBuilder(api), IBcApiOperation, IBcSkuFilter
{
    public async Task<BcResult> SendAsync(BcId priceListId, CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.PriceListRecordsV3(priceListId),
            Filter,
            Options,
            cancellationToken
        );
}