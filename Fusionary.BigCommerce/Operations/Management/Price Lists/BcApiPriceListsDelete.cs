namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListsDelete(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public async Task<BcResult> SendAsync(BcId priceListId, CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.PriceListsV3(priceListId),
            Filter,
            Options,
            cancellationToken
        );
}