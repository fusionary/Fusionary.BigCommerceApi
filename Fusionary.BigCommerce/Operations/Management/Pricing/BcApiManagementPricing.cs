namespace Fusionary.BigCommerce.Operations;

public class BcApiManagementPricing : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiManagementPricing(IBcApi api)
    {
        _api = api;
    }

    /// <summary>
    /// Calculate batch pricing for products for a specific channel, currency, and customer group.
    /// </summary>
    /// <remarks>
    /// https://developer.bigcommerce.com/docs/rest-management/pricing/products
    /// </remarks>
    public BcApiManagementPricingGetProducts Products() => new(_api);
}
