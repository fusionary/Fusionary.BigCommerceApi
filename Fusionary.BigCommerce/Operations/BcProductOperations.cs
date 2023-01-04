namespace Fusionary.BigCommerce.Operations;

public class BcProductOperations
{
    private readonly IBigCommerceApi _api;

    public BcProductOperations(IBigCommerceApi api)
    {
        _api = api;
    }

    public BcProductCreate Create() => new(_api);

    public BcProductDelete Delete() => new(_api);

    public BcProductsDeleteBulk DeleteBulk() => new(_api);

    public BcProductGet Get() => new(_api);

    public BcProductImagesGet GetImages() => new(_api);

    public BcProductsSearch Search() => new(_api);

    public BcProductUpdate Update() => new(_api);
}