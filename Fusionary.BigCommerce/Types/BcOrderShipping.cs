namespace Fusionary.BigCommerce.Types;

public record BcOrderShipping
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("order_id")]
    public int OrderId { get; set; }

    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("company")]
    public string? Company { get; set; }

    [JsonPropertyName("street_1")]
    public string? Street1 { get; set; }

    [JsonPropertyName("street_2")]
    public string? Street2 { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("zip")]
    public string? Zip { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("country_iso2")]
    public string? CountryIso2 { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("items_total")]
    public int ItemsTotal { get; set; }

    [JsonPropertyName("items_shipped")]
    public int ItemsShipped { get; set; }

    [JsonPropertyName("shipping_method")]
    public string? ShippingMethod { get; set; }

    [JsonPropertyName("base_cost")]
    public BcFloat BaseCost { get; set; }

    [JsonPropertyName("cost_ex_tax")]
    public BcFloat CostExTax { get; set; }

    [JsonPropertyName("cost_inc_tax")]
    public BcFloat CostIncTax { get; set; }

    [JsonPropertyName("cost_tax")]
    public BcFloat CostTax { get; set; }

    [JsonPropertyName("cost_tax_class_id")]
    public int CostTaxClassId { get; set; }

    [JsonPropertyName("base_handling_cost")]
    public BcFloat BaseHandlingCost { get; set; }

    [JsonPropertyName("handling_cost_ex_tax")]
    public BcFloat HandlingCostExTax { get; set; }

    [JsonPropertyName("handling_cost_inc_tax")]
    public BcFloat HandlingCostIncTax { get; set; }

    [JsonPropertyName("handling_cost_tax")]
    public BcFloat HandlingCostTax { get; set; }

    [JsonPropertyName("handling_cost_tax_class_id")]
    public int HandlingCostTaxClassId { get; set; }

    [JsonPropertyName("shipping_zone_id")]
    public int ShippingZoneId { get; set; }

    [JsonPropertyName("shipping_zone_name")]
    public string? ShippingZoneName { get; set; }

    [JsonPropertyName("shipping_quotes")]
    public BcOrderShippingQuote? ShippingQuotes { get; set; }

    [JsonPropertyName("form_fields")]
    public List<BcNameValue>? FormFields { get; set; }
}