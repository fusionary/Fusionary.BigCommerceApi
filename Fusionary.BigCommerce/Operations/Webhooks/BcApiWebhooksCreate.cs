namespace Fusionary.BigCommerce.Operations;

public class BcApiWebhooksCreate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    /// <summary>
    /// Create a new webhook
    /// </summary>
    /// <remarks>
    /// https://developer.bigcommerce.com/docs/integrations/webhooks
    /// </remarks>
    public async Task<BcResult> SendAsync(BcWebhookPost data, CancellationToken cancellationToken = default) =>
        await Api.PostDataAsync<BcWebhook>(
            BcEndpoint.WebhooksV3(),
            data,
            Filter,
            Options,
            cancellationToken
        );
}