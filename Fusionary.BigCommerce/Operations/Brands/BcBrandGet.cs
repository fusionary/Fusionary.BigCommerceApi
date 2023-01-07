namespace Fusionary.BigCommerce.Operations;

public class BcBrandGet : BcRequestBuilder,
    IBcIncludeFieldsFilter,
    IBcExcludeFieldsFilter
{
    public BcBrandGet(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcBrand>> SendAsync(object brandId, CancellationToken cancellationToken) =>
        SendAsync<BcBrand>(brandId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(object brandId, CancellationToken cancellationToken) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.BrandsV3(brandId),
            Filter,
            Options,
            cancellationToken
        );
}