namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("{Type}")]
public record BcBulkPricingTier
{
    /// <summary>
    /// The minimum inclusive quantity of a product to satisfy this rule. Must be greater than or equal to zero.
    /// </summary>
    public int? QuantityMin { get; set; }

    /// <summary>
    /// The maximum inclusive quantity of a product to satisfy this rule. Must be greater than the `quantity_min` value – unless this field has a value of 0 (zero), in which case there will be no maximum bound for this rule. Required in /POST.
    /// </summary>
    public int? QuantityMax { get; set; }

    /// <summary>
    /// The type of adjustment that is made. Values: `price` - the adjustment amount per product; `percent` - the adjustment as a percentage of the original price; `fixed` - the adjusted absolute price of the product. Required in /POST.
    /// </summary>
    public BcBulkPricingTierType Type { get; set; }

    /// <summary>
    /// The discount can be a fixed dollar amount or a percentage. For a fixed dollar amount enter it as an integer and the response will return as an integer. For percentage enter the amount as the percentage divided by 100 using string format. For example 10% percent would be “.10”. The response will return as an integer.  Required in /POST.
    /// </summary>
    public int Amount { get; set; }
}
