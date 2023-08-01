namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListAssignments : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiPriceListAssignments(IBcApi api)
    {
        _api = api;
    }

    public BcApiPriceListAssignmentsCreate Create() => new(_api);

    public BcApiPriceListAssignmentsDelete Delete() => new(_api);

    public BcApiPriceListAssignmentsGet Get() => new(_api);

    public BcApiPriceListAssignmentsUpsert Upsert() => new(_api);
}
