namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandsDeleteBulk(IBcApi api) : BcRequestBuilder(api), IBcApiOperation,
    IBcNameFilter,
    IBcPageTitleFilter
{
    public async Task<BcResult> SendAsync(CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.BrandsV3(),
            Filter,
            Options,
            cancellationToken
        );
}