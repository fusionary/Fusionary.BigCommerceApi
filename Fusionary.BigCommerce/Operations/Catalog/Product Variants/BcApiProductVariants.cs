namespace Fusionary.BigCommerce.Operations;

public class BcApiProductVariants(IBcApi api) : IBcApiOperation
{
    public BcApiProductVariantsCreate Create() => new(api);

    public BcApiProductVariantsDelete Delete() => new(api);

    public BcApiProductVariantsGet Get() => new(api);

    public BcApiProductVariantsGetAll GetAll() => new(api);

    public BcApiProductVariantsUpdate Update() => new(api);
    
    public BcApiProductVariantsUpdateBatch UpdateBatch() => new(api);
}