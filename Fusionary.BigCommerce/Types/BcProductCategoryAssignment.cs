namespace Fusionary.BigCommerce.Types;

public record BcProductCategoryAssignment
{
    public required BcId ProductId { get; init; }

    public required BcId CategoryId { get; init; }
}