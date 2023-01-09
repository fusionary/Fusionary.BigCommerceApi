namespace Fusionary.BigCommerce.Operations;

public class BcSummaryGet : BcRequestBuilder
{
    public BcSummaryGet(IBcApi api) : base(api)
    { }

    public async Task<BcResultData<BcCatalogSummary>> SendAsync(CancellationToken cancellationToken) =>
        await Api.GetDataAsync<BcCatalogSummary>(
            BcEndpoint.SummaryV3(),
            Filter,
            Options,
            cancellationToken
        );
}