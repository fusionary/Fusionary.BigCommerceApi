namespace Fusionary.BigCommerce.Operations;

public class BcApiCartGet : BcRequestBuilder, IBcApiOperation
{
    public BcApiCartGet(IBcApi api) : base(api)
    {
        this.Add("include", "line_items.physical_items.options,shipping_address,shipping_lines");

    }

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