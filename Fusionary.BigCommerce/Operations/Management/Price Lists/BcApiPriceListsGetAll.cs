namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListsGetAll : BcRequestBuilder,
    IBcApiOperation,
    IBcIdFilter,
    IBcIdRangeFilter,
    IBcPageableFilter,
    IBcNameFilter,
    IBcDateCreatedFilter,
    IBcDateModifiedFilter
{
    public BcApiPriceListsGetAll(IBcApi api) : base(api)
    { }

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
