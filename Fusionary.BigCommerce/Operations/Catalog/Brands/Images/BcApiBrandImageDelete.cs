namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandImageDelete(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public async Task<BcResult> SendAsync(BcId brandId, CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.BrandImageV3(brandId),
            Filter,
            Options,
            cancellationToken
        );
}