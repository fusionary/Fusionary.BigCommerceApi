namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandsGetAll(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter,
    IBcIdFilter,
    IBcIdRangeFilter,
    IBcPageableFilter,
    IBcNameFilter,
    IBcPageTitleFilter
{
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