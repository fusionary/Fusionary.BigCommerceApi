namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("Order Product {Id}: {Name}")]
public record BcOrderCatalogProductPut : BcOrderCatalogProductPost
{
    public int Id { get; init; }
}