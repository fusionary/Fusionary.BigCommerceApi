namespace Fusionary.BigCommerce.Operations;

/// <summary>
/// BigCommerce Management API
/// </summary>
/// <see href="https://developer.bigcommerce.com/docs/rest-management" />
public class BcApiManagement : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiManagement(IBcApi api)
    {
        _api = api;
    }
}
