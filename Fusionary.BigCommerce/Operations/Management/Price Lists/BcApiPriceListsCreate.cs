namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListsCreate : BcRequestBuilder, IBcApiOperation
{
    public BcApiPriceListsCreate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcPriceList>> SendAsync(
        BcPriceListPost priceList,
        CancellationToken cancellationToken = default
    ) => Api.PostDataAsync<BcPriceList>(
        BcEndpoint.PriceListsV3(),
        priceList,
        Filter,
        Options,
        cancellationToken
    );
}