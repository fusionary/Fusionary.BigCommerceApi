namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandsGet : BcRequestBuilder,
    IBcApiOperation,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter
{
    public BcApiBrandsGet(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcBrand>> SendAsync(BcId brandId, CancellationToken cancellationToken = default) =>
        SendAsync<BcBrand>(brandId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(BcId brandId, CancellationToken cancellationToken = default) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.BrandsV3(brandId),
            Filter,
            Options,
            cancellationToken
        );
}