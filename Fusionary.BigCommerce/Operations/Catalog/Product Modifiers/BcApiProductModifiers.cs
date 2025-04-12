namespace Fusionary.BigCommerce.Operations;

public class BcApiProductModifiers(IBcApi api) : IBcApiOperation
{
    public BcApiProductModifiersCreate Create() => new(api);

    public BcApiProductModifiersDelete Delete() => new(api);

    public BcApiProductModifiersGet Get() => new(api);

    public BcApiProductModifiersGetAll GetAll() => new(api);

    public BcApiProductModifiersUpdate Update() => new(api);
}