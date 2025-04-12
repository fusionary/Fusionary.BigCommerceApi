namespace Fusionary.BigCommerce.Operations;

public class BcApiProductImages(IBcApi api) : IBcApiOperation
{
    public BcApiProductImagesCreate Create() => new(api);

    public BcApiProductImagesDelete Delete() => new(api);

    public BcApiProductImagesGet Get() => new(api);

    public BcApiProductImagesUpdate Update() => new(api);
}