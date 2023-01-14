namespace Fusionary.BigCommerce.Operations;

public class BcApiSummary : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiSummary(IBcApi api)
    {
        _api = api;
    }

    /// <summary>
    /// Returns a lightweight inventory summary from the BigCommerce Catalog.
    /// </summary>
    public BcSummaryGet Get() => new(_api);
}