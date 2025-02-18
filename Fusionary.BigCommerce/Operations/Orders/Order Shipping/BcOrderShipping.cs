namespace Fusionary.BigCommerce.Operations;

public record BcOrderShipping
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Company { get; set; }
    public string? Street1 { get; set; }
    public string? Street2 { get; set; }
    public string? City { get; set; }
    public string? Zip { get; set; }
    public string? Country { get; set; }
    public string? CountryIso2 { get; set; }
    public string? State { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public int ItemsTotal { get; set; }
    public int ItemsShipped { get; set; }
    public string? ShippingMethod { get; set; }
    public string? BaseCost { get; set; }
    public string? CostExTax { get; set; }
    public string? CostIncTax { get; set; }
    public string? CostTax { get; set; }
    public int CostTaxClassId { get; set; }
    public string? BaseHandlingCost { get; set; }
    public string? HandlingCostExTax { get; set; }
    public string? HandlingCostIncTax { get; set; }
    public string? HandlingCostTax { get; set; }
    public int HandlingCostTaxClassId { get; set; }
    public int ShippingZoneId { get; set; }
    public string? ShippingZoneName { get; set; }
    public BcOrderShippingQuote? ShippingQuotes { get; set; }
    public List<object>? FormFields { get; set; }
}