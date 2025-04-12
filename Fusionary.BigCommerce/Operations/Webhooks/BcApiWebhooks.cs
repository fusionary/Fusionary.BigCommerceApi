namespace Fusionary.BigCommerce.Operations;

/// <summary>
/// Webhook Management API
/// </summary>
/// <see href="https://developer.bigcommerce.com/docs/webhooks/overview" />
public class BcApiWebhooks : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiWebhooks(IBcApi api)
    {
        _api = api;
    }
}