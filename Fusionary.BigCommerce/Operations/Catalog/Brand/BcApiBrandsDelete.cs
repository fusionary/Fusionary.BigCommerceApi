namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandsDelete : BcRequestBuilder, IBcApiOperation
{
    public BcApiBrandsDelete(IBcApi api) : base(api)
    { }

    public async Task<BcResult> SendAsync<TProduct>(BcId brandId, CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.BrandsV3(brandId),
            Filter,
            Options,
            cancellationToken
        );
}