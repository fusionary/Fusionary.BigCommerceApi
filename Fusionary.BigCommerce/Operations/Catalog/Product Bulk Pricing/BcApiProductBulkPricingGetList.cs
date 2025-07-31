namespace Fusionary.BigCommerce.Operations.Product_Bulk_Pricing;

public class BcApiProductBulkPricingGetList(IBcApi api) : BcRequestBuilder(api), IBcApiOperation, IBcIncludeFieldsFilter, IBcExcludeFieldsFilter
{
    public Task<BcResultPaged<BcProductBulkPricingRule>> SendAsync(BcId productId, CancellationToken cancellationToken) =>
        SendAsync<BcProductBulkPricingRule>(productId, cancellationToken);
    public Task<BcResultPaged<TResponse>> SendAsync<TResponse>(BcId productId, CancellationToken cancellationToken = default) =>
        Api.GetPagedAsync<TResponse>(BcEndpoint.ProductBulkPricingRulesV3(productId), Filter, Options, cancellationToken);
}