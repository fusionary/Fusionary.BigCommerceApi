namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListsGetAll(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcIdFilter,
    IBcIdRangeFilter,
    IBcPageableFilter,
    IBcNameFilter,
    IBcDateCreatedFilter,
    IBcDateModifiedFilter
{
    public Task<BcResultPaged<BcPriceList>> SendAsync(CancellationToken cancellationToken = default) =>
        SendAsync<BcPriceList>(cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.PriceListsV3(),
            Filter,
            Options,
            cancellationToken
        );
}