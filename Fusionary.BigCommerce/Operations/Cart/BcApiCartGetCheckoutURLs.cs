namespace Fusionary.BigCommerce.Operations;

public class BcApiCartGetCheckoutURLs : BcRequestBuilder, IBcApiOperation
{
    public BcApiCartGetCheckoutURLs(IBcApi api) : base(api)
    {
      //  this.Add("include", "line_items.physical_items.options,shipping_address,shipping_lines");

    }

    public Task<BcResultData<BcCartRedirectURLs>> SendAsync(
        string cartId,
        BcCartRedirectQueryParms parameterss,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcCartRedirectURLs>(cartId, parameterss, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(string cartId, BcCartRedirectQueryParms parameterss, CancellationToken cancellationToken = default) =>
        await Api.PostDataAsync<T>(
            BcEndpoint.CartRedirectsV3(cartId),
            parameterss,
            Filter,
            Options,
            cancellationToken
        );
}