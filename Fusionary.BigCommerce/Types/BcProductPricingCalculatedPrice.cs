namespace Fusionary.BigCommerce.Types;

public class BcProductPricingCalculatedPrice
{
    public double AsEntered { get; init; }
    public bool EnteredInclusive { get; init; }
    public double TaxExclusive { get; init; }
    public double TaxInclusive { get; init; }
}