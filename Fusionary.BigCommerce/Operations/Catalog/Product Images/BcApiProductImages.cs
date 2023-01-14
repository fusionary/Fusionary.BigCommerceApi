namespace Fusionary.BigCommerce.Operations;

public class BcApiProductImages : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiProductImages(IBcApi api)
    {
        _api = api;
    }

    public BcApiProductImagesCreate Create() => new(_api);

    public BcApiProductImagesDelete Delete() => new(_api);

    public BcApiProductImagesGet Get() => new(_api);

    public BcApiProductImagesUpdate Update() => new(_api);
}