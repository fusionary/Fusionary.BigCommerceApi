namespace Fusionary.BigCommerce.Operations;

public class BcApiBrand : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiBrand(IBcApi api)
    {
        _api = api;
    }

    public BcApiBrandsCreate Create() => new(_api);

    public BcApiBrandsDelete Delete() => new(_api);

    public BcApiBrandsDeleteBulk DeleteBulk() => new(_api);

    public BcApiBrandsGet Get() => new(_api);

    /// <summary>
    /// Search/Get all brands
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/api-reference/c2610608c20c8-get-all-brands
    /// </remarks>
    public BcApiBrandsGetAll GetAll() => new(_api);

    public BcApiBrandsUpdate Update() => new(_api);
}