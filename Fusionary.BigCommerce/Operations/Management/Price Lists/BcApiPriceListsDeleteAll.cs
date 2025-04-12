namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListsDeleteAll : BcRequestBuilder, IBcApiOperation,
    IBcNameFilter,
    IBcPageTitleFilter
{
    public BcApiPriceListsDeleteAll(IBcApi api) : base(api)
    { }

    public async Task<BcResult> SendAsync<TProduct>(CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.PriceListsV3(),
            Filter,
            Options,
            cancellationToken
        );
}