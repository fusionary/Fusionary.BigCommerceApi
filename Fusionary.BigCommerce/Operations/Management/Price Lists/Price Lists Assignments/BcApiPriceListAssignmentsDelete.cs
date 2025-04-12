namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListAssignmentsDelete(IBcApi api) : BcRequestBuilder(api), IBcApiOperation,
    IBcPriceListFilter,
    IBcChannelFilter,
    IBcCustomerGroupFilter,
    IBcIdFilter
{
    public async Task<BcResult> SendAsync(CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.PriceListAssignmentsV3(),
            Filter,
            Options,
            cancellationToken
        );
}