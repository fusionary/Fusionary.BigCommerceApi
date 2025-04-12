namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryMetafields(IBcApi api) : IBcApiOperation
{
    public BcCategoryMetafieldsCreate Create() => new(api);

    public BcCategoryMetafieldDelete Delete() => new(api);

    public BcCategoryMetafieldsGet Get() => new(api);

    public BcCategoryMetafieldsGetAll GetAll() => new(api);

    public BcCategoryMetafieldsUpdate Update() => new(api);
}