namespace Fusionary.BigCommerce.Types;

public record BcModifierOptionValue : BcProductOptionValue
{
   

    public BcAdjusters? Adjusters { get; set; }
}