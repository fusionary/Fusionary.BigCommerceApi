namespace Fusionary.BigCommerce.Types;

public record BcPriceListAssignmentPost : BcPriceListAssignmentUpsert
{
    public int PriceListId { get; init; }
}