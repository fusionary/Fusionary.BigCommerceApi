namespace Fusionary.BigCommerce.Operations;

public record BcStorefrontTokenGet : BcRequestBuilder<BcStorefrontTokenGet>
{
    public BcStorefrontTokenGet(IBigCommerceApi api) : base(api)
    { }

    public async Task<BcDataResult<BcTokenResponse>> SendAsync(
        BcTokenRequest request,
        CancellationToken cancellationToken
    ) =>
        await Api.PostDataAsync<BcTokenResponse>(
            BcEndpoint.StorefrontTokensV3(),
            request,
            Filter,
            cancellationToken
        );
}