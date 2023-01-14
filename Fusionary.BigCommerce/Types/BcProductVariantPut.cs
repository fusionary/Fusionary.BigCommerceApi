namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Id: {Id} Sku: {Sku} Product ID: {ProductId}")]
public record BcProductVariantPut : BcProductVariantPost
{
    public int Id { get; set; }
}