namespace Fusionary.BigCommerce.Types;

public record BcAdjusterItem
{
    public BcAdjusterType Adjuster { get; set; }

    public BcFloat AdjusterValue { get; set; }
}