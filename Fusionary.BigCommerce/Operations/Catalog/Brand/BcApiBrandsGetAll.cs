namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandsGetAll : BcRequestBuilder,
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcIdFilter,
    IBcIdRangeFilter,
    IBcPageableFilter,
    IBcNameFilter,
    IBcPageTitleFilter
{
    internal BcApiBrandsGetAll(IBcApi api) : base(api)
    { }

    public Task<BcResultPaged<BcBrand>> SendAsync(CancellationToken cancellationToken = default) =>
        SendAsync<BcBrand>(cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.BrandsV3(),
            Filter,
            Options,
            cancellationToken
        );
}