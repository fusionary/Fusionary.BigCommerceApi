namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandsDelete(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public async Task<BcResult> SendAsync(BcId brandId, CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.BrandsV3(brandId),
            Filter,
            Options,
            cancellationToken
        );
}