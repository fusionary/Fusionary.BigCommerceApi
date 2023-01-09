namespace Fusionary.BigCommerce.Operations;

public class BcSummaryOperations
{
    private readonly IBcApi _api;

    public BcSummaryOperations(IBcApi api)
    {
        _api = api;
    }

    /// <summary>
    /// Returns a lightweight inventory summary from the BigCommerce Catalog.
    /// </summary>
    public BcSummaryGet Get() => new(_api);
}