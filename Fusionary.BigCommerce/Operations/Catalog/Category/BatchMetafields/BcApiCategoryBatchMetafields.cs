namespace Fusionary.BigCommerce.Operations.BatchMetafields;

public class BcApiCategoryBatchMetafields(IBcApi api) : IBcApiOperation
{
    public BcApiCategoryBatchMetafieldsGetAll GetAll() => new(api);
}