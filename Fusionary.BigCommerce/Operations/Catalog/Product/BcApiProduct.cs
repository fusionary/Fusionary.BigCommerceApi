namespace Fusionary.BigCommerce.Operations;

public class BcApiProduct(IBcApi api) : IBcApiOperation
{
    public BcApiProductCreate Create() => new(api);

    public BcApiProductsDelete Delete() => new(api);

    public BcApiProductsDeleteBulk DeleteBulk() => new(api);

    public BcApiProductGet Get() => new(api);

    /// <summary>
    /// Search/Get all products
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/api-reference/4101d472a814d-get-all-products
    /// </remarks>
    public BcApiProductsSearch Search() => new(api);

    public BcApiProductsUpdate Update() => new(api);
}