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
    /// Read-Only.  Required for updates.
    /// </remarks>
    public BcId? Id { get; set; }

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
    /// You can express the adjustment type as either a fixed dollar amount or a percentage.
    /// Send a number; the response will return a number for price and fixed adjustments.
    /// Divide the adjustment percentage by 100 and send the result in string format.
    /// For example, represent 10% as “.10”.
    /// The response will return a float value for both price and percentage adjustments.
    /// </summary>
    /// <remarks>
    /// Required in /POST.
    /// </remarks>
    public decimal Amount { get; set; }
}