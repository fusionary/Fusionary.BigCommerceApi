namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListsDeleteAll(IBcApi api) : BcRequestBuilder(api), IBcApiOperation,
    IBcNameFilter,
    IBcPageTitleFilter
{
    public async Task<BcResult> SendAsync(CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.PriceListsV3(),
            Filter,
            Options,
            cancellationToken
        );
}