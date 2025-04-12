namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderMetafields(IBcApi api) : IBcApiOperation
{
    public BcApiOrderMetafieldsCreate Create() => new(api);

    public BcApiOrderMetafieldsDelete Delete() => new(api);

    public BcApiOrderMetafieldsGet Get() => new(api);

    public BcApiOrderMetafieldsGetAll GetAll() => new(api);

    public BcApiOrderMetafieldsUpdate Update() => new(api);
}