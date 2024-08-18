namespace Fusionary.BigCommerce.Operations;

public class BcApiCartCreate : BcRequestBuilder, IBcApiOperation
{
    public BcApiCartCreate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcCartResponseFull>> SendAsync(
        BcCartPost cart,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcCartResponseFull>(cart, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(object cart, CancellationToken cancellationToken = default) =>
        await Api.PostDataAsync<T>(
            BcEndpoint.CartV3(),
            cart,
            Filter,
            Options,
            cancellationToken
        );
}