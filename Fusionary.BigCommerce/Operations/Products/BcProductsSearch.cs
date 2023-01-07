namespace Fusionary.BigCommerce.Operations;

public class BcProductsSearch : BcRequestBuilder,
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
    internal BcProductsSearch(IBcApi api) : base(api)
    { }

    public Task<BcResultPaged<BcProductFull>> SendAsync(CancellationToken cancellationToken) =>
        SendAsync<BcProductFull>(cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(CancellationToken cancellationToken) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.ProductsV3(),
            Filter,
            Options,
            cancellationToken
        );
}