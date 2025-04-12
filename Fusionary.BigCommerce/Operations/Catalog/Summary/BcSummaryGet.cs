namespace Fusionary.BigCommerce.Operations;

public class BcSummaryGet(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public async Task<BcResultData<BcCatalogSummary>> SendAsync(CancellationToken cancellationToken = default) =>
        await Api.GetDataAsync<BcCatalogSummary>(
            BcEndpoint.SummaryV3(),
            Filter,
            Options,
            cancellationToken
        );
}