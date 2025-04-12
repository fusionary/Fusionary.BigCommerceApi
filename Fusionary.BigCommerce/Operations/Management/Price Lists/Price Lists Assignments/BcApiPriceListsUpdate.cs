namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListAssignmentsUpsert : BcRequestBuilder, IBcApiOperation
{
    public BcApiPriceListAssignmentsUpsert(IBcApi api) : base(api)
    { }

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