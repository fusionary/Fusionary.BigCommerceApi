namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceList : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiPriceList(IBcApi api)
    {
        _api = api;
    }

    public BcApiPriceListAssignments Assignments() => new(_api);

    public BcApiPriceListsCreate Create() => new(_api);

    public BcApiPriceListsDelete Delete() => new(_api);

    public BcApiPriceListsDeleteAll DeleteAll() => new(_api);

    public BcApiPriceListsGet Get() => new(_api);

    /// <summary>
    /// Returns a list of Price Lists. Optional parameters can be passed in.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/docs/rest-management/price-lists#get-all-price-lists
    /// </remarks>
    public BcApiPriceListsGetAll GetAll() => new(_api);

    public BcApiPriceListRecords Records() => new(_api);

    public BcApiPriceListsUpdate Update() => new(_api);
}