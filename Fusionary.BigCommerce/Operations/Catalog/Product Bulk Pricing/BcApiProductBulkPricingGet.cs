namespace Fusionary.BigCommerce.Operations.Product_Bulk_Pricing;

public class BcApiProductBulkPricingGet(IBcApi api) : BcRequestBuilder(api), IBcApiOperation, IBcIncludeFieldsFilter, IBcExcludeFieldsFilter
{
    public Task<BcResultData<BcProductBulkPricingRule>> SendAsync(BcId productId, BcId productBulkPricingRuleId, CancellationToken cancellationToken) =>
        SendAsync<BcProductBulkPricingRule>(productId,  productBulkPricingRuleId, cancellationToken);
    public Task<BcResultData<TResponse>> SendAsync<TResponse>(BcId productId, BcId productBulkPricingRuleId, CancellationToken cancellationToken = default) =>
        Api.GetDataAsync<TResponse>(BcEndpoint.ProductBulkPricingRulesV3(productId, productBulkPricingRuleId), Filter, Options, cancellationToken);
}