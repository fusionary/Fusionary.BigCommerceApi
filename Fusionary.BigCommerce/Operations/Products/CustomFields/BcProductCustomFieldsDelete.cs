namespace Fusionary.BigCommerce.Operations;

public class BcProductCustomFieldsDelete : BcRequestBuilder
{
    public BcProductCustomFieldsDelete(IBcApi api) : base(api)
    { }

    public Task<BcResult> SendAsync(object productId, object customFieldId, CancellationToken cancellationToken) =>
        Api.DeleteAsync(BcEndpoint.ProductCustomFieldsV3(productId, customFieldId), Filter, Options, cancellationToken);
}