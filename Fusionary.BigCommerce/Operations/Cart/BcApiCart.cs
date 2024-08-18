using Fusionary.BigCommerce.Operations.Cart;

namespace Fusionary.BigCommerce.Operations;

public class BcApiCart : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiCart(IBcApi api)
    {
        _api = api;
    }

    public BcApiCartLineAdd AddLineItem() => new(_api);
    public BcApiCartUpdateLine UpdateLineItem() => new(_api);
    public BcApiCartDeleteItem DeleteLineItem() => new(_api);
    public BcApiCartCreate Create() => new(_api);
    public BcApiCartDelete Delete() => new(_api);
    public BcApiCartGet Get() => new(_api);
     
}