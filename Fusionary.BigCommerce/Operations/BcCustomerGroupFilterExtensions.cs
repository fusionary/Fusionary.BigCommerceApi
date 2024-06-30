namespace Fusionary.BigCommerce.Operations;

public static class BcCustomerGroupFilterExtensions
{
    /// <summary>
    /// Filter items by customer_group_id.
    /// </summary>
    public static T CustomerGroup<T>(this T builder, BcId customerGroupId)
        where T : IBcCustomerGroupFilter =>
        builder.Add("customer_group_id", customerGroupId.Value);
    
    /// <summary>
    /// Filter items by customer_group_id.
    /// </summary>
    public static T CustomerGroup<T>(this T builder, IEnumerable<BcId> customerGroupId)
        where T : IBcCustomerGroupFilter =>
        builder.Add("customer_group_id:in", customerGroupId.Select(x => x.Value));
}