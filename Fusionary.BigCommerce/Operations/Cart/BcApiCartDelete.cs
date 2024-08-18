namespace Fusionary.BigCommerce.Operations;

public class BcApiCartDelete : BcRequestBuilder, IBcApiOperation
{
    public BcApiCartDelete(IBcApi api) : base(api)
    { }

    public async Task<BcResult> SendAsync<TProduct>(string cartId, CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.CartV3(cartId),
            Filter,
            Options,
            cancellationToken
        );
}
