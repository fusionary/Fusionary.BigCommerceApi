namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListRecords : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiPriceListRecords(IBcApi api)
    {
        _api = api;
    }

    public BcApiPriceListRecordUpsert Upsert() => new(_api);
}