namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListAssignments(IBcApi api) : IBcApiOperation
{
    public BcApiPriceListAssignmentsCreate Create() => new(api);

    public BcApiPriceListAssignmentsDelete Delete() => new(api);

    public BcApiPriceListAssignmentsGet Get() => new(api);

    public BcApiPriceListAssignmentsUpsert Upsert() => new(api);
}