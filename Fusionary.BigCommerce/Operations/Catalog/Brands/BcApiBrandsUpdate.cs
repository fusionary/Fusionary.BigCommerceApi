namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandsUpdate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcBrand>> SendAsync(
        BcBrand brand,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcBrand>(brand.Id, brand, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        BcId brandId,
        object brand,
        CancellationToken cancellationToken = default
    ) =>
        await Api.PutDataAsync<T>(
            BcEndpoint.BrandsV3(brandId),
            brand,
            Filter,
            Options,
            cancellationToken
        );
}