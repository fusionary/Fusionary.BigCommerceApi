namespace Fusionary.BigCommerce.Operations;

public class BcApiWebhooksGetAll(IBcApi api)
    : BcRequestBuilder(api), IBcApiOperation, IBcPageableFilter, IBcWebhookSearchFilter
{
    /// <summary>
    /// Get a webhook by ID
    /// </summary>
    /// <remarks>
    /// https://developer.bigcommerce.com/docs/integrations/webhooks
    /// </remarks>
    public async Task<BcResultPaged<BcWebhook>> SendAsync(CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<BcWebhook>(
            BcEndpoint.WebhooksV3(),
            Filter,
            Options,
            cancellationToken
        );
}