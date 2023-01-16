namespace Fusionary.BigCommerce.Operations;

public class BcApiProductsSearch : BcRequestBuilder,
    IBcApiOperation,
    IBcPageableFilter,
    IBcExcludeFieldsFilter,
    IBcIncludeFieldsFilter,
    IBcIdFilter,
    IBcIdRangeFilter,
    IBcProductIncludeFilter,
    IBcDateLastImportedFilter,
    IBcDateModifiedFilter,
    IBcProductSearchFilter
{
    public BcApiProductsSearch(IBcApi api) : base(api)
    { }

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