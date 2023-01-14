namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandsCreate : BcRequestBuilder, IBcApiOperation
{
    public BcApiBrandsCreate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcOrderResponseFull>> SendAsync(
        BcBrand brand,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcOrderResponseFull>(brand, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(object brand, CancellationToken cancellationToken = default) =>
        await Api.PostDataAsync<T>(
            BcEndpoint.BrandsV3(),
            brand,
            Filter,
            Options,
            cancellationToken
        );
}