namespace Fusionary.BigCommerce.Operations;

public class BcApiWebhooksUpdate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public async Task<BcResultData<BcWebhook>> SendAsync(
        BcWebhookPut webhook,
        CancellationToken cancellationToken = default
    ) =>
        await Api.PutDataAsync<BcWebhook>(
            BcEndpoint.WebhooksV3(webhook.Id),
            webhook,
            Filter,
            Options,
            cancellationToken
        );
}