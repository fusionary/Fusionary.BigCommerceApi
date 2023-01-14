namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandMetafields : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiBrandMetafields(IBcApi api)
    {
        _api = api;
    }

    public BcApiBrandMetafieldsCreate Create() => new(_api);

    public BcApiBrandMetafieldDelete Delete() => new(_api);

    public BcApiBrandMetafieldsGet Get() => new(_api);

    public BcApiBrandMetafieldsGetAll GetAll() => new(_api);

    public BcApiBrandMetafieldsUpdate Update() => new(_api);
}