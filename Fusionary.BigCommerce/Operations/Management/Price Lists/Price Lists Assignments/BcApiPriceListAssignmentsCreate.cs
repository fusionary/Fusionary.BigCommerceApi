namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListAssignmentsCreate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public async Task<BcResult> SendAsync(
        BcPriceListAssignmentPost priceListAssignment,
        CancellationToken cancellationToken = default
    ) => await Api.PostDataAsync<object>(
        BcEndpoint.PriceListAssignmentsV3(),
        priceListAssignment,
        Filter,
        Options,
        cancellationToken
    );
}