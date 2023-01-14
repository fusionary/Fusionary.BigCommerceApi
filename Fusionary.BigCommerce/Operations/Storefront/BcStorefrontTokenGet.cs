namespace Fusionary.BigCommerce.Operations;

public class BcStorefrontTokenGet : BcRequestBuilder, IBcApiOperation
{
    public BcStorefrontTokenGet(IBcApi api) : base(api)
    { }

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