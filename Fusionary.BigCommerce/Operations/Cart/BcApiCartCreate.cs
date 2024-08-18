namespace Fusionary.BigCommerce.Operations;

public class BcApiCartCreate : BcRequestBuilder, IBcApiOperation
{
    public BcApiCartCreate(IBcApi api) : base(api)
    { 
        this.Add("include", "line_items.physical_items.options,shipping_address,shipping_lines");
    }

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