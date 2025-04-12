namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceList(IBcApi api) : IBcApiOperation
{
    public BcApiPriceListAssignments Assignments() => new(api);

    public BcApiPriceListsCreate Create() => new(api);

    public BcApiPriceListsDelete Delete() => new(api);

    public BcApiPriceListsDeleteAll DeleteAll() => new(api);

    public BcApiPriceListsGet Get() => new(api);

    /// <summary>
    /// Returns a list of Price Lists. Optional parameters can be passed in.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/docs/rest-management/price-lists#get-all-price-lists
    /// </remarks>
    public BcApiPriceListsGetAll GetAll() => new(api);

    public BcApiPriceListRecords Records() => new(api);

    public BcApiPriceListsUpdate Update() => new(api);
}