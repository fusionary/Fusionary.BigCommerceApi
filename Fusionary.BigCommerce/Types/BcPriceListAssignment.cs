namespace Fusionary.BigCommerce.Types;

public record BcPriceListAssignment : BcPriceListAssignmentPost
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int Id { get; init; }
}