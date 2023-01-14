namespace Fusionary.BigCommerce.Operations;

public class BcApiOrderMetafields : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiOrderMetafields(IBcApi api)
    {
        _api = api;
    }

    public BcApiOrderMetafieldsCreate Create() => new(_api);

    public BcApiOrderMetafieldsDelete Delete() => new(_api);

    public BcApiOrderMetafieldsGet Get() => new(_api);

    public BcApiOrderMetafieldsGetAll GetAll() => new(_api);

    public BcApiOrderMetafieldsUpdate Update() => new(_api);
}