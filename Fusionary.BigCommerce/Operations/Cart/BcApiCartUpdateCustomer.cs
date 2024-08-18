namespace Fusionary.BigCommerce.Operations;

public class BcApiCartCreate : BcRequestBuilder, IBcApiOperation
{
    public BcApiCartCreate(IBcApi api) : base(api)
    { 
        this.Add("include", "line_items.physical_items.options,shipping_address,shipping_lines");
    }

    public Task<BcResultData<BcCartResponseFull>> SendAsync(
        string cartId,
        BcCartPost cart,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcCartResponseFull>(cartId,cart, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(string cartId,object cart, CancellationToken cancellationToken = default) =>
        await Api.PutDataAsync<T>(
            BcEndpoint.CartV3(cartId),
            cart,
            Filter,
            Options,
            cancellationToken
        );
}