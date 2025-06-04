namespace Fusionary.BigCommerce.Operations.BatchMetafields;

public class BcApiBrandBatchMetafields(IBcApi api) : IBcApiOperation
{
    public BcApiBrandBatchMetafieldsGetAll GetAll() => new(api);
}