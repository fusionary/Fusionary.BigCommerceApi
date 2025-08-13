namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListRecordGetAll(IBcApi api) : BcRequestBuilder(api), IBcPageableFilter, IBcApiOperation, IBcProductIncludeFilter
{
    public Task<BcResultPaged<BcPriceListRecord>> SendAsync(BcId priceListId, CancellationToken cancellationToken = default) =>
        SendAsync<BcPriceListRecord>(priceListId, cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(BcId priceListId, CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.PriceListRecordsV3(priceListId),
            Filter,
            Options,
            cancellationToken
        );    
}