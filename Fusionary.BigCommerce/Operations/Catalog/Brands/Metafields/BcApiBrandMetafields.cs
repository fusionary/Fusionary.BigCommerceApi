namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandMetafields(IBcApi api) : IBcApiOperation
{
    public BcApiBrandMetafieldsCreate Create() => new(api);

    public BcApiBrandMetafieldDelete Delete() => new(api);

    public BcApiBrandMetafieldsGet Get() => new(api);

    public BcApiBrandMetafieldsGetAll GetAll() => new(api);

    public BcApiBrandMetafieldsUpdate Update() => new(api);
}