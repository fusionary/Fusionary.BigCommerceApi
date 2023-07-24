namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("{Adjuster} {AdjusterValue}")]
public record BcAdjusterItem
{
    public BcAdjusterType Adjuster { get; set; }

    public BcFloat AdjusterValue { get; set; }
}
