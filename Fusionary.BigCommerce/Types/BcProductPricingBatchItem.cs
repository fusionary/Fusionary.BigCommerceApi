namespace Fusionary.BigCommerce.Types;

public class BcProductPricingBatchItem
{
    public required int ProductId { get; init; }
    public int? VariantId { get; init; }
    public BcProductPricingBatchOption[]? Options { get; init; }
}