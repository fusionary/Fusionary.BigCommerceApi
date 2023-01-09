namespace Fusionary.BigCommerce.Types;

public record BcAdjusterPurchasingDisabled
{
    public bool Status { get; set; }
    public string Message { get; set; } = null!;
}