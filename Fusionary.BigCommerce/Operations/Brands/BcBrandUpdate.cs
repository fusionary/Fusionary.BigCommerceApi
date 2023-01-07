namespace Fusionary.BigCommerce.Operations;

public class BcBrandUpdate : BcRequestBuilder
{
    public BcBrandUpdate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcBrand>> SendAsync(
        BcBrand brand,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcBrand>(brand.Id, brand, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(int brandId, object brand, CancellationToken cancellationToken) =>
        await Api.PutDataAsync<T>(
            BcEndpoint.BrandsV3(brandId),
            brand,
            Filter,
            Options,
            cancellationToken
        );
}