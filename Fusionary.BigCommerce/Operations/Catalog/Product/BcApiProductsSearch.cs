namespace Fusionary.BigCommerce.Operations;

public class BcApiProductsSearch(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcChannelFilter,
    IBcDateLastImportedFilter,
    IBcDateModifiedFilter,
    IBcExcludeFieldsFilter,
    IBcIdFilter,
    IBcIdRangeFilter,
    IBcIncludeFieldsFilter,
    IBcPageableFilter,
    IBcProductIncludeFilter,
    IBcProductSearchFilter
{
    public Task<BcResultPaged<BcProductFull>> SendAsync(CancellationToken cancellationToken = default) =>
        SendAsync<BcProductFull>(cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.ProductsV3(),
            Filter,
            Options,
            cancellationToken
        );
}