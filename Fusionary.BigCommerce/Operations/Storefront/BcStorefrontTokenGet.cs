namespace Fusionary.BigCommerce.Operations;

public class BcStorefrontTokenGet : BcRequestBuilder
{
    public BcStorefrontTokenGet(IBcApi api) : base(api)
    { }

    public async Task<BcResultData<BcTokenResponse>> SendAsync(
        BcTokenRequest request,
        CancellationToken cancellationToken
    ) =>
        await Api.PostDataAsync<BcTokenResponse>(
            BcEndpoint.StorefrontTokensV3(),
            request,
            Filter,
            Options,
            cancellationToken
        );
}