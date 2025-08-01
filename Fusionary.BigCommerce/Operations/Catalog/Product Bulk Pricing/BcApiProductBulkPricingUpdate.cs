namespace Fusionary.BigCommerce.Operations.Product_Bulk_Pricing;

public class BcApiProductBulkPricingUpdate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcProductBulkPricingRule>> SendAsync(BcId productId, BcId productBulkPricingRuleId, BcProductBulkPricingRule productBulkPricingRule, CancellationToken cancellationToken) =>
        SendAsync<BcProductBulkPricingRule>(productId, productBulkPricingRuleId, productBulkPricingRule, cancellationToken);
    public Task<BcResultData<TResponse>> SendAsync<TResponse>(BcId productId, BcId productBulkPricingRuleId, object productBulkPricingRule, CancellationToken cancellationToken = default) =>
        Api.PutDataAsync<TResponse>(BcEndpoint.ProductBulkPricingRulesV3(productId, productBulkPricingRuleId), productBulkPricingRule, Filter, Options, cancellationToken);
}