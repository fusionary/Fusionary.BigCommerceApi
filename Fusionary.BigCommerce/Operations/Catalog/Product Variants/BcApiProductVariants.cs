namespace Fusionary.BigCommerce.Operations;

public class BcApiProductVariants : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiProductVariants(IBcApi api)
    {
        _api = api;
    }

    public BcApiProductVariantsCreate Create() => new(_api);

    public BcApiProductVariantsDelete Delete() => new(_api);

    public BcApiProductVariantsGet Get() => new(_api);

    public BcApiProductVariantsGetAll GetAll() => new(_api);

    public BcApiProductVariantsUpdate Update() => new(_api);
}