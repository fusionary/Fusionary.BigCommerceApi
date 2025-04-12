namespace Fusionary.BigCommerce.Operations;

public class BcApiManagementPricingGetProducts(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
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