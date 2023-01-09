namespace Fusionary.BigCommerce.Types;

public record BcAdjusters
{
    public BcAdjusterItem? Price { get; set; }
    public BcAdjusterItem? Weight { get; set; }
    public string? ImageUrl { get; set; }
    public BcAdjusterPurchasingDisabled? PurchasingDisabled { get; set; }
}