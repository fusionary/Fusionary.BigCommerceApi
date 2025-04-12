namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListRecords(IBcApi api) : IBcApiOperation
{
    public BcApiPriceListRecordUpsert Upsert() => new(api);
}