namespace Fusionary.BigCommerce.Operations;

public class BcApiProductModifiers : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiProductModifiers(IBcApi api)
    {
        _api = api;
    }

    public BcApiProductModifiersCreate Create() => new(_api);

    public BcApiProductModifiersDelete Delete() => new(_api);

    public BcApiProductModifiersGet Get() => new(_api);

    public BcApiProductModifiersGetAll GetAll() => new(_api);

    public BcApiProductModifiersUpdate Update() => new(_api);
}