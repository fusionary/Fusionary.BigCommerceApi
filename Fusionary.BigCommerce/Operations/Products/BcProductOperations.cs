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

    public BcProductImagesCreate CreateImage() => new(_api);

    public BcProductImageUpdate UpdateImage() => new(_api);

    public BcProductImageDelete DeleteImage() => new(_api);

    #endregion

    #region Modifiers

    public BcProductModifiersGet GetModifier() => new(_api);

    public BcProductModifiersGetList GetModifierList() => new(_api);

    public BcProductModifiersCreate CreateModifier() => new(_api);

    public BcProductModifiersUpdate UpdateModifier() => new(_api);

    public BcProductModifiersDelete DeleteModifier() => new(_api);

    #endregion

    #region Products

    public BcProductCreate Create() => new(_api);

    public BcProductGet Get() => new(_api);

    /// <summary>
    /// Search/Get all products
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/api-reference/4101d472a814d-get-all-products
    /// </remarks>
    public BcProductsSearch Search() => new(_api);

    public BcProductsUpdate Update() => new(_api);

    public BcProductsDelete Delete() => new(_api);

    public BcProductsDeleteBulk DeleteBulk() => new(_api);

    #endregion

    #region Custom Fields

    public BcProductCustomsFieldCreate CreateCustomField() => new(_api);

    public BcProductCustomFieldsGet GetCustomField() => new(_api);

    public BcProductCustomFieldsGetList GetCustomFieldList() => new(_api);

    public BcProductCustomFieldsUpdate UpdateCustomField() => new(_api);

    public BcProductCustomFieldsDelete DeleteCustomField() => new(_api);

    #endregion

    #region Metafields

    public BcProductMetafieldsCreate CreateMetafields() => new(_api);

    public BcProductMetafieldsGet GetMetafields() => new(_api);

    public BcProductMetafieldsGetAll GetAllMetafields() => new(_api);

    public BcProductMetafieldsUpdate UpdateMetafields() => new(_api);

    public BcProductMetafieldselete DeleteMetafield() => new(_api);

    #endregion
}