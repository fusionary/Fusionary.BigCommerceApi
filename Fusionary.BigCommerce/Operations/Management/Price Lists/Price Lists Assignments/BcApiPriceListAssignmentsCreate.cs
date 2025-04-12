namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListAssignmentsCreate : BcRequestBuilder, IBcApiOperation
{
    public BcApiPriceListAssignmentsCreate(IBcApi api) : base(api)
    { }

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