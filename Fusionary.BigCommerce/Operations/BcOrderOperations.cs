namespace Fusionary.BigCommerce.Operations;

public record BcOrderOperations
{
    private readonly IBigCommerceApi _api;

    public BcOrderOperations(IBigCommerceApi api)
    {
        _api = api;
    }

    public BcOrdersSearch Search() => new(_api);

    public BcOrdersGet Get() => new(_api);

    public BcOrdersCreate Create() => new(_api);

    public BcOrdersArchive Archive() => new(_api);
}