namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListsDelete : BcRequestBuilder, IBcApiOperation
{
    public BcApiPriceListsDelete(IBcApi api) : base(api)
    { }

    public async Task<BcResult> SendAsync<TProduct>(BcId priceListId, CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.PriceListsV3(priceListId),
            Filter,
            Options,
            cancellationToken
        );
}