namespace Fusionary.BigCommerce.Operations;

public class BcApiProductMetafields(IBcApi api) : IBcApiOperation
{
    public BcApiProductMetafieldsCreate Create() => new(api);

    public BcApiProductMetafieldsDelete Delete() => new(api);

    public BcApiProductMetafieldsGet Get() => new(api);

    public BcApiProductMetafieldsGetAll GetAll() => new(api);

    public BcApiProductMetafieldsUpdate Update() => new(api);
}