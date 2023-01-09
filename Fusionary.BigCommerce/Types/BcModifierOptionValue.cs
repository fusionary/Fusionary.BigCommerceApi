namespace Fusionary.BigCommerce.Types;

public record BcModifierOptionValue : BcProductOptionValue
{
    public int OptionId { get; set; }

    public BcAdjusters? Adjusters { get; set; }
}