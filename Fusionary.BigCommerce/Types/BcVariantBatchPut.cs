namespace Fusionary.BigCommerce.Types;

[NoReorder]
public record BcVariantBatchPut: BcProductVariantPost
{
    public int? Id { get; set; }
    
    /// <summary>
    /// SKU
    /// </summary>
    /// <remarks>
    /// MaxLength: 255
    /// </remarks>
    public new string? Sku { get; set; } = null!;
}