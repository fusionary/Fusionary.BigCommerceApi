namespace Fusionary.BigCommerce;


public class BcProductManagementApi
{
    private readonly IBigCommerceApi _api;

    public BcProductManagementApi(IBigCommerceApi api)
    {
        _api = api;
    }

    public BcProductGet Get() => new (_api);
    
    public BcProductsSearch Search() => new (_api);
    
    public BcProductUpdate Update() => new (_api);
    
    public BcProductCreate Create() => new (_api);
    
    public BcProductDelete Delete() => new (_api);
    
    public BcDeleteProducts DeleteBulk() => new (_api);
    
    public BcProductImagesGet GetImages() => new (_api);
}