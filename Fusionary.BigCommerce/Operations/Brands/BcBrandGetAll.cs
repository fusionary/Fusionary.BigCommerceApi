namespace Fusionary.BigCommerce.Operations;

public class BcBrandGetAll : BcRequestBuilder,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcIdFilter,
    IBcIdRangeFilter,
    IBcPageableFilter,
    IBcNameFilter,
    IBcPageTitleFilter
{
    internal BcBrandGetAll(IBcApi api) : base(api)
    { }

    public Task<BcResultPaged<BcBrand>> SendAsync(CancellationToken cancellationToken) =>
        SendAsync<BcBrand>(cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(CancellationToken cancellationToken) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.BrandsV3(),
            Filter,
            Options,
            cancellationToken
        );
}