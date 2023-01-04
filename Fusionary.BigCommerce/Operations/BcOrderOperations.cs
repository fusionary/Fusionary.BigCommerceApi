namespace Fusionary.BigCommerce.Operations;

public record BcOrderOperations
{
    private readonly IBigCommerceApi _api;

    public BcOrderOperations(IBigCommerceApi api)
    {
        _api = api;
    }

    public BcOrdersArchive Archive() => new(_api);

    public BcOrdersCreate Create() => new(_api);

    public BcOrdersGet Get() => new(_api);

    public BcOrderMetafieldsGet GetMetafields() => new(_api);

    public BcOrderMetafieldsCreate CreateMetafields() => new(_api);

    public BcOrderMetafieldDelete DeleteMetafield() => new(_api);

    public BcOrdersSearch Search() => new(_api);
}