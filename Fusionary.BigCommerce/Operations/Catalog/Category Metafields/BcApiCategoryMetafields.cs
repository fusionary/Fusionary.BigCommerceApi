namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryMetafields : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiCategoryMetafields(IBcApi api)
    {
        _api = api;
    }

    public BcCategoryMetafieldsCreate Create() => new(_api);

    public BcCategoryMetafieldDelete Delete() => new(_api);

    public BcCategoryMetafieldsGet Get() => new(_api);

    public BcCategoryMetafieldsGetAll GetAll() => new(_api);

    public BcCategoryMetafieldsUpdate Update() => new(_api);
}