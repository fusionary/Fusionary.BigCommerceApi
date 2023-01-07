namespace Fusionary.BigCommerce.Operations;

public class BcBrandCreate : BcRequestBuilder
{
    public BcBrandCreate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcOrderResponseFull>> SendAsync(
        BcBrand brand,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcOrderResponseFull>(brand, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(object brand, CancellationToken cancellationToken) =>
        await Api.PostDataAsync<T>(
            BcEndpoint.BrandsV3(),
            brand,
            Filter,
            Options,
            cancellationToken
        );
}