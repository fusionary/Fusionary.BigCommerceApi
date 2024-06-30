namespace Fusionary.BigCommerce.Types;

public record BcProductChannelAssignment
{
    public required BcId ProductId { get; init; }

    public required BcId ChannelId { get; init; }
}