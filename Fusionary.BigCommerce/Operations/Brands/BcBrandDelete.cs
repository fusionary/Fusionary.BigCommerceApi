namespace Fusionary.BigCommerce.Operations;

public class BcBrandDelete : BcRequestBuilder
{
    public BcBrandDelete(IBcApi api) : base(api)
    { }

    public async Task<BcResult> SendAsync<TProduct>(object brandId, CancellationToken cancellationToken) =>
        await Api.DeleteAsync(
            BcEndpoint.BrandsV3(brandId),
            Filter,
            Options,
            cancellationToken
        );
}