namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandsCreate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcBrand>> SendAsync(
        BcBrandPost brand,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcBrand>(brand, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(object brand, CancellationToken cancellationToken = default) =>
        await Api.PostDataAsync<T>(
            BcEndpoint.BrandsV3(),
            brand,
            Filter,
            Options,
            cancellationToken
        );
}