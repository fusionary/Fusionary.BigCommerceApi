namespace Fusionary.BigCommerce.Operations;

public class BcApiManagementPricing(IBcApi api) : IBcApiOperation
{
    /// <summary>
    /// Calculate batch pricing for products for a specific channel, currency, and customer group.
    /// </summary>
    /// <remarks>
    /// https://developer.bigcommerce.com/docs/rest-management/pricing/products
    /// </remarks>
    public BcApiManagementPricingGetProducts Products() => new(api);
}