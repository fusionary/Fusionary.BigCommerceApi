using Fusionary.BigCommerce.Operations.CustomerAttributes;
using Fusionary.BigCommerce.Operations.Geography;

namespace Fusionary.BigCommerce.Operations;

/// <summary>
/// BigCommerce Management API
/// </summary>
/// <see href="https://developer.bigcommerce.com/docs/rest-management" />
public class BcApiManagement(IBcApi api) : IBcApiOperation
{
    /// <summary>
    /// Manage Customers
    /// </summary>
    public BcApiCustomer Customer() => new(api);

    /// <summary>
    /// Manage Customer Groups
    /// </summary>
    public BcApiCustomerGroup CustomerGroup() => new(api);
    
    /// <summary>
    /// Manage Customer Attribute Definitions
    /// </summary>
    public BcApiCustomerAttributeDefinition CustomerAttributeDefinition() => new(api);

    /// <summary>
    /// Manage Orders
    /// </summary>
    public BcApiOrdersOverview Orders() => new(api);
    
    /// <summary>
    /// Manage Price Lists
    /// </summary>
    /// <remarks>
    /// https://developer.bigcommerce.com/api-docs/store-management/price-list-overview
    /// </remarks>
    public BcApiPriceList PriceList() => new(api);

    /// <summary>
    /// Get product pricing
    /// </summary>
    public BcApiManagementPricing Pricing() => new(api);

    public BcApiGeography Geography() => new(api);
}