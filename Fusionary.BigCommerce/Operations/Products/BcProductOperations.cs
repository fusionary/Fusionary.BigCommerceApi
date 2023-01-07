namespace Fusionary.BigCommerce.Operations;

public class BcProductOperations
{
    private readonly IBcApi _api;

    public BcProductOperations(IBcApi api)
    {
        _api = api;
    }

    #region Images

    public BcProductImagesGet GetImages() => new(_api);

    #endregion

    #region Products

    public BcProductCreate Create() => new(_api);

    public BcProductGet Get() => new(_api);

    public BcProductsSearch Search() => new(_api);

    public BcProductUpdate Update() => new(_api);

    public BcProductDelete Delete() => new(_api);

    public BcProductDeleteBulk DeleteBulk() => new(_api);

    #endregion

    #region Custom Fields

    public BcProductCustomFieldCreate CreateCustomField() => new(_api);

    public BcProductCustomFieldGet GetCustomField() => new(_api);

    public BcProductCustomFieldGetList GetCustomFieldList() => new(_api);

    public BcProductCustomFieldUpdate UpdateCustomField() => new(_api);

    public BcProductCustomFieldDelete DeleteCustomField() => new(_api);

    #endregion

    #region Metafields

    public BcProductMetafieldsCreate CreateMetafields() => new(_api);

    public BcProductMetafieldsGet GetMetafields() => new(_api);

    public BcProductMetafieldsGetAll GetAllMetafields() => new(_api);

    public BcProductMetafieldsUpdate UpdateMetafields() => new(_api);

    public BcProductMetafieldDelete DeleteMetafield() => new(_api);

    #endregion
}