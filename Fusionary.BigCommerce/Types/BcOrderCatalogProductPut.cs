namespace Fusionary.BigCommerce.Types;

public record BcOrderCatalogProductPut : BcOrderCatalogProductPost
{
    public int Id { get; init; }
}