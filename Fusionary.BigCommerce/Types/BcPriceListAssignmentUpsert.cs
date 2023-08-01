namespace Fusionary.BigCommerce.Types;

public record BcPriceListAssignmentUpsert
{
    public int CustomerGroupId { get; init; }

    public int ChannelId { get; init; }
}