namespace Fusionary.BigCommerce.Operations;

public class BcApiCartGet : BcRequestBuilder, IBcApiOperation
{
    public BcApiCartGet(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcCartResponseFull>> SendAsync(
        string cartId,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcCartResponseFull>(cartId, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(string cartId, CancellationToken cancellationToken = default) =>
        await Api.GetDataAsync<T>(
            BcEndpoint.CartV3(cartId),
            Filter,
            Options,
            cancellationToken
        );
}