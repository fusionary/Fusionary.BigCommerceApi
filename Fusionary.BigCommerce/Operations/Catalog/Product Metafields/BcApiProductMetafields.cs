namespace Fusionary.BigCommerce.Operations;

public class BcApiProductMetafields : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiProductMetafields(IBcApi api)
    {
        _api = api;
    }

    public BcApiProductMetafieldsCreate Create() => new(_api);

    public BcApiProductMetafieldsDelete Delete() => new(_api);

    public BcApiProductMetafieldsGet Get() => new(_api);

    public BcApiProductMetafieldsGetAll GetAll() => new(_api);

    public BcApiProductMetafieldsUpdate Update() => new(_api);
}