namespace Fusionary.BigCommerce.Operations;

public class BcApiProduct : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiProduct(IBcApi api)
    {
        _api = api;
    }

    public BcApiProductCreate Create() => new(_api);

    public BcApiProductsDelete Delete() => new(_api);

    public BcApiProductsDeleteBulk DeleteBulk() => new(_api);

    public BcApiProductGet Get() => new(_api);

    /// <summary>
    /// Search/Get all products
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/api-reference/4101d472a814d-get-all-products
    /// </remarks>
    public BcApiProductsSearch Search() => new(_api);

    public BcApiProductsUpdate Update() => new(_api);
}