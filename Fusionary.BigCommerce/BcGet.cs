using Microsoft.AspNetCore.Http;

namespace Fusionary.BigCommerce;

public class BcGet
{
    private readonly IBigCommerceApi _api;

    public BcGet(IBigCommerceApi api)
    {
        _api = api;
    }

    public BcGetProduct Product(int id) => Product(id, QueryString.Empty);

    public BcGetProduct Product(int id, QueryString queryString) => new(_api, id, queryString);

    public BcGetProducts Products() => new(_api, QueryString.Empty);

    public BcGetProducts Products(QueryString queryString) => new(_api, queryString);

    public BcGetOrders Orders() => new(_api, QueryString.Empty);

    public BcGetOrders Orders(QueryString queryString) => new(_api, queryString);
}