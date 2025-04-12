namespace Fusionary.BigCommerce.Operations;

public class BcStorefrontTokenGet(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public async Task<BcResultData<BcTokenResponse>> SendAsync(
        BcTokenRequest request,
        CancellationToken cancellationToken = default
    ) =>
        await Api.PostDataAsync<BcTokenResponse>(
            BcEndpoint.StorefrontTokensV3(),
            request,
            Filter,
            Options,
            cancellationToken
        );
}