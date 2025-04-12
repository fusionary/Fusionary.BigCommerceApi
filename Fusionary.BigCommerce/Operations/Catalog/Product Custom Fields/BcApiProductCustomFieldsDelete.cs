namespace Fusionary.BigCommerce.Operations;

public class BcApiProductCustomFieldsDelete(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResult> SendAsync(
        BcId productId,
        BcId customFieldId,
        CancellationToken cancellationToken = default
    ) =>
        Api.DeleteAsync(BcEndpoint.ProductCustomFieldsV3(productId, customFieldId), Filter, Options, cancellationToken);
}