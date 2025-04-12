namespace Fusionary.BigCommerce.Operations;

public class BcApiWebhooksDelete(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public async Task<BcResult> SendAsync(BcId webhookId, CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.WebhooksV3(webhookId),
            Filter,
            Options,
            cancellationToken
        );
}