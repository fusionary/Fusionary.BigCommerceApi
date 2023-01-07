namespace Fusionary.BigCommerce.Operations;

public class BcBrandOperations
{
    private readonly IBcApi _api;

    public BcBrandOperations(IBcApi api)
    {
        _api = api;
    }

    #region Brand

    public BcBrandCreate Create() => new(_api);

    public BcBrandGet Get() => new(_api);

    /// <summary>
    /// Search/Get all brands
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/api-reference/c2610608c20c8-get-all-brands
    /// </remarks>
    public BcBrandGetAll Search() => new(_api);

    public BcBrandUpdate Update() => new(_api);

    public BcBrandDelete Delete() => new(_api);

    public BcBrandDeleteBulk DeleteBulk() => new(_api);

    #endregion

    #region Metafields

    public BcBrandMetafieldsCreate CreateMetafields() => new(_api);

    public BcBrandMetafieldsGet GetMetafields() => new(_api);

    public BcBrandMetafieldsGetAll GetAllMetafields() => new(_api);

    public BcBrandMetafieldsUpdate UpdateMetafields() => new(_api);

    public BcBrandMetafieldDelete DeleteMetafield() => new(_api);

    #endregion
}