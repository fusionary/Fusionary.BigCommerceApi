namespace Fusionary.BigCommerce.Operations;

public record BcOrderOperations
{
    private readonly IBcApi _api;

    public BcOrderOperations(IBcApi api)
    {
        _api = api;
    }

    #region Products

    public BcOrderProductGet GetProducts() => new(_api);

    #endregion

    #region Orders

    public BcOrderCreate Create() => new(_api);

    public BcOrderGet Get() => new(_api);

    public BcOrderSearch Search() => new(_api);

    public BcOrderUpdate Update() => new(_api);

    public BcOrderArchive Archive() => new(_api);

    #endregion

    #region Metafields

    public BcOrderMetafieldsCreate CreateMetafields() => new(_api);

    public BcOrderMetafieldsGet GetMetafields() => new(_api);

    public BcOrderMetafieldsGetAll GetAllMetafields() => new(_api);

    public BcOrderMetafieldsUpdate UpdateMetafields() => new(_api);

    public BcOrderMetafieldDelete DeleteMetafield() => new(_api);

    #endregion
}