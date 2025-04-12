namespace Fusionary.BigCommerce.Operations;

public class BcApiSummary(IBcApi api) : IBcApiOperation
{
    /// <summary>
    /// Returns a lightweight inventory summary from the BigCommerce Catalog.
    /// </summary>
    public BcSummaryGet Get() => new(api);
}