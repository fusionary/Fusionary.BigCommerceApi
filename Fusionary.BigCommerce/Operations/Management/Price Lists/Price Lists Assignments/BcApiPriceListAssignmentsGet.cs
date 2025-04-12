namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListAssignmentsGet(IBcApi api) : BcRequestBuilder(api),
    IBcApiOperation,
    IBcIdFilter,
    IBcIdRangeFilter,
    IBcPageableFilter,
    IBcChannelFilter,
    IBcPriceListFilter
{
    public async Task<BcResultPaged<BcPriceListAssignment>> SendAsync(
        CancellationToken cancellationToken = default
    ) => await SendAsync<BcPriceListAssignment>(cancellationToken);

    public async Task<BcResultPaged<T>> SendAsync<T>(
        CancellationToken cancellationToken = default
    ) =>
        await Api.GetPagedAsync<T>(
            BcEndpoint.PriceListAssignmentsV3(),
            Filter,
            Options,
            cancellationToken
        );
}