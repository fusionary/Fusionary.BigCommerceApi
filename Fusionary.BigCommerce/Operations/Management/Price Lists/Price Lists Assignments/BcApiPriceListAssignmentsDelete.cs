namespace Fusionary.BigCommerce.Operations;

public class BcApiPriceListAssignmentsDelete : BcRequestBuilder, IBcApiOperation,
    IBcPriceListFilter,
    IBcChannelFilter,
    IBcCustomerGroupFilter,
    IBcIdFilter
{
    public BcApiPriceListAssignmentsDelete(IBcApi api) : base(api)
    { }

    public async Task<BcResult> SendAsync<TProduct>(CancellationToken cancellationToken = default) =>
        await Api.DeleteAsync(
            BcEndpoint.PriceListAssignmentsV3(),
            Filter,
            Options,
            cancellationToken
        );
}
