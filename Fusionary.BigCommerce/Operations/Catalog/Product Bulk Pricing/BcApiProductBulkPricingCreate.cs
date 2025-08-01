namespace Fusionary.BigCommerce.Operations.Product_Bulk_Pricing;

public class BcApiProductBulkPricingCreate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcProductBulkPricingRule>> SendAsync(BcId productId, BcProductBulkPricingRule productBulkPricingRule, CancellationToken cancellationToken) =>
        SendAsync<BcProductBulkPricingRule>(productId,  productBulkPricingRule, cancellationToken);
    public Task<BcResultData<TResponse>> SendAsync<TResponse>(BcId productId, object productBulkPricingRule, CancellationToken cancellationToken = default) =>
        Api.PostDataAsync<TResponse>(BcEndpoint.ProductBulkPricingRulesV3(productId), productBulkPricingRule, Filter, Options, cancellationToken);
}