namespace Fusionary.BigCommerce.Operations;

public class BcApiManagementPricingGetProducts : BcRequestBuilder, IBcApiOperation
{
    public BcApiManagementPricingGetProducts(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcProductPricing[]>> SendAsync(
        BcProductPricingBatchInput input,
        CancellationToken cancellationToken = default
    ) => Api.PostDataAsync<BcProductPricing[]>(
        BcEndpoint.PricingProductsV3(),
        input,
        Filter,
        Options,
        cancellationToken
    );
}
