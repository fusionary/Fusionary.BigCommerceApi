namespace Fusionary.BigCommerce.Operations;

public class BcApiCartLineAdd : BcRequestBuilder, IBcApiOperation
{
    public BcApiCartLineAdd(IBcApi api) : base(api)
    {
        this.Add("include", "line_items.physical_items.options,shipping_address,shipping_lines");

    }

    public Task<BcResultData<BcCartResponseFull>> SendAsync(
        string cartId,
        BcCartLineItems cartItems,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcCartResponseFull>(cartId, cartItems, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(string cartId, object cartItems, CancellationToken cancellationToken = default) =>
        await Api.PostDataAsync<T>(
            BcEndpoint.CartV3(),
            cartItems,
            Filter,
            Options,
            cancellationToken
        );
}