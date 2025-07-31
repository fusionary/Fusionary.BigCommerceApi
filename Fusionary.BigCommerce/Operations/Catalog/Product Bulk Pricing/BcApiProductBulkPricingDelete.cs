namespace Fusionary.BigCommerce.Operations.Product_Bulk_Pricing;

public class BcApiProductBulkPricingDelete(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResult> SendAsync(BcId productId, BcId productBulkPricingRuleId, CancellationToken cancellationToken = default) =>
        Api.DeleteAsync(BcEndpoint.ProductBulkPricingRulesV3(productId, productBulkPricingRuleId), Filter, Options, cancellationToken);
}