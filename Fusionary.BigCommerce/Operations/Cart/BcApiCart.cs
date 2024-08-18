namespace Fusionary.BigCommerce.Operations;

public class BcApiCart : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiCart(IBcApi api)
    {
        _api = api;
    }

     
    public BcApiCartDeleteItem DeleteLineItem() => new(_api);
    public BcApiCartCreate Create() => new(_api);
    public BcApiCartDelete Delete() => new(_api);
    public BcApiCartGet Get() => new(_api);
     
}