namespace Fusionary.BigCommerce.Operations;

/// <summary>
/// Webhook Management API
/// </summary>
/// <see href="https://developer.bigcommerce.com/docs/webhooks/overview" />
public class BcApiWebhooks(IBcApi api) : IBcApiOperation
{
    public BcApiWebhooksCreate Create() => new(api);

    public BcApiWebhooksDelete Delete() => new(api);

    public BcApiWebhooksGet Get() => new(api);

    public BcApiWebhooksGetAll Search() => new(api);

    public BcApiWebhooksUpdate Update() => new(api);
}