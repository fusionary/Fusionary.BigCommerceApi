namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListAssignmentsGet : BcRequestBuilder,
    IBcApiOperation,
    IBcIdFilter,
    IBcIdRangeFilter,
    IBcPageableFilter,
    IBcChannelFilter,
    IBcPriceListFilter
{
    public BcApiPriceListAssignmentsGet(IBcApi api) : base(api)
    { }

    public async Task<BcResultPaged<BcPriceListAssignment>> SendAsync<T>(CancellationToken cancellationToken = default) =>
        await Api.GetPagedAsync<BcPriceListAssignment>(
            BcEndpoint.PriceListAssignmentsV3(),
            Filter,
            Options,
            cancellationToken
        );
}
