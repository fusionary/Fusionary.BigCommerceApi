namespace Fusionary.BigCommerce.Operations;

public class BcApiProductCustomFieldsDelete : BcRequestBuilder, IBcApiOperation
{
    public BcApiProductCustomFieldsDelete(IBcApi api) : base(api)
    { }

    public Task<BcResult> SendAsync(
        BcId productId,
        BcId customFieldId,
        CancellationToken cancellationToken = default
    ) =>
        Api.DeleteAsync(BcEndpoint.ProductCustomFieldsV3(productId, customFieldId), Filter, Options, cancellationToken);
}