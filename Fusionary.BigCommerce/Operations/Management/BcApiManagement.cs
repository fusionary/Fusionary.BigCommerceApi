using Fusionary.BigCommerce.Operations.Customers;
using Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

namespace Fusionary.BigCommerce.Operations;

/// <summary>
/// BigCommerce Management API
/// </summary>
/// <see href="https://developer.bigcommerce.com/docs/rest-management" />
public class BcApiManagement : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiManagement(IBcApi api)
    {
        _api = api;
    }

    /// <summary>
    /// Manage Price Lists
    /// </summary>
    /// <remarks>
    /// https://developer.bigcommerce.com/api-docs/store-management/price-list-overview
    /// </remarks>
    public BcApiPriceList PriceList() => new (_api);

    /// <summary>
    /// Get product pricing
    /// </summary>
    public BcApiManagementPricing Pricing() => new(_api);
    
    /// <summary>
    /// Manage Customer Groups
    /// </summary>
    public BcApiCustomerGroup CustomerGroup() => new(_api);

    /// <summary>
    /// Manage Customers
    /// </summary>
    public BcApiCustomer Customer() => new(_api);
}
