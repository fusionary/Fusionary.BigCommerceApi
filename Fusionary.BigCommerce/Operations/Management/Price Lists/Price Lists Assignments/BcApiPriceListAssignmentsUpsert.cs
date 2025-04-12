namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListAssignmentsUpsert(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcPriceListAssignment>> SendAsync(
        BcId priceListId,
        BcPriceListAssignmentUpsert priceListAssignment,
        CancellationToken cancellationToken = default
    ) => Api.PutDataAsync<BcPriceListAssignment>(
        BcEndpoint.PriceListAssignmentsV3(priceListId),
        priceListAssignment,
        Filter,
        Options,
        cancellationToken
    );
}