namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("{Adjuster} {AdjusterValue}")]
public record BcAdjusterItem
{
    /// <summary>
    /// The type of adjuster for either the price or the weight of the variant, when the modifier value is selected on the
    /// storefront.
    /// </summary>
    public BcAdjusterType Adjuster { get; init; }

    /// <summary>
    /// The numeric amount by which the adjuster will change either the price or the weight of the variant, when the modifier
    /// value is selected on the storefront.
    /// </summary>
    public BcFloat AdjusterValue { get; init; }
}