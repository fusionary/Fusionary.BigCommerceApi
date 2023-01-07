namespace Fusionary.BigCommerce.Operations;

public class BcCategoryOperations
{
    private readonly IBcApi _api;

    public BcCategoryOperations(IBcApi api)
    {
        _api = api;
    }

    #region Category

    public BcCategoryCreate Create() => new(_api);

    public BcCategoryGet Get() => new(_api);

    /// <summary>
    /// Search/Get all categories
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/api-reference/9cc3a53863922-get-all-categories
    /// </remarks>
    public BcCategoryGetAll Search() => new(_api);

    public BcCategoryUpdate Update() => new(_api);

    public BcCategoryDelete Delete() => new(_api);

    /// <summary>
    /// Deletes Category objects. At least one filter parameter is required to perform the DELETE operation.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/api-reference/d4e96c2f5d289-delete-categories
    /// </remarks>
    public BcCategoryDeleteBulk DeleteBulk() => new(_api);

    #endregion

    #region Metafields

    public BcCategoryMetafieldsCreate CreateMetafields() => new(_api);

    public BcCategoryMetafieldsGet GetMetafields() => new(_api);

    public BcCategoryMetafieldsGetAll GetAllMetafields() => new(_api);

    public BcCategoryMetafieldsUpdate UpdateMetafields() => new(_api);

    public BcCategoryMetafieldDelete DeleteMetafield() => new(_api);

    #endregion
}