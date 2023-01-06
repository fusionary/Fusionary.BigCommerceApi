namespace Fusionary.BigCommerce.Types;

/// <summary>
/// Bulk Pricing Rule
/// </summary>
/// <remarks>
/// See https://developer.bigcommerce.com/api-reference/a994ed8385a86-get-a-bulk-pricing-rule
/// </remarks>
public record BcProductBulkPricingRule
{
    /// <summary>
    /// Unique ID of the Bulk Pricing Rule.
    /// </summary>
    /// <remarks>
    /// Read-Only.
    /// </remarks>
    public int Id { get; set; }

    /// <summary>
    /// The minimum inclusive quantity of a product to satisfy this rule. Must be greater than or equal to zero.
    /// </summary>
    /// <remarks>
    /// Required in /POST.
    /// </remarks>
    public int QuantityMin { get; set; }

    /// <summary>
    /// The maximum inclusive quantity of a product to satisfy this rule.
    /// Must be greater than the quantity_min value – unless this field has a value of 0 (zero), in which case there
    /// will be no maximum bound for this rule.
    /// </summary>
    /// <remarks>
    /// Required in /POST.
    /// </remarks>
    public int QuantityMax { get; set; }

    /// <summary>
    /// The type of adjustment that is made.
    /// </summary>
    public BcBulkPricingRuleType Type { get; set; }

    /// <summary>
    /// The discount can be a fixed dollar amount or a percentage. For a fixed dollar amount enter it as an integer
    /// and the response will return as an integer. For percentage enter the amount as the percentage divided by 100
    /// using string format. For example 10% percent would be “10”. The response will return as an integer.
    /// </summary>
    /// <remarks>
    /// Required in /POST.
    /// </remarks>
    public int Amount { get; set; }
}