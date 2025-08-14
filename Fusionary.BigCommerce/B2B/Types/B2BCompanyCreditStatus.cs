namespace Fusionary.BigCommerce.B2B.Types;

public class B2BCompanyCreditStatus
{
    [JsonPropertyName("creditEnabled")]
    public bool IsCreditEnabled { get; set; }

    [JsonPropertyName("creditCurrency")] 
    public string? CreditCurrency { get; set; } = string.Empty;
    
    [JsonPropertyName("availableCredit")]
    public decimal? AvailableCredit { get; set; }
    
    [JsonPropertyName("limitPurchases")]
    public bool? IsLimitPurchases { get; set; }
    
    [JsonPropertyName("creditHold")]
    public bool? IsOnCreditHold { get; set; }
}