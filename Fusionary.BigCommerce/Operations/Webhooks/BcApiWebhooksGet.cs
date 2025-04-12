namespace Fusionary.BigCommerce.Operations;

public class BcApiWebhooksGet(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public async Task<BcResultData<BcWebhook>> SendAsync(
        BcId webhookId,
        CancellationToken cancellationToken = default
    ) =>
        await Api.GetDataAsync<BcWebhook>(
            BcEndpoint.WebhooksV3(webhookId),
            Filter,
            Options,
            cancellationToken
        );
}