namespace Fusionary.BigCommerce.Operations;

public class BcProductImageDelete : BcRequestBuilder
{
    public BcProductImageDelete(IBcApi api) : base(api)
    { }

    public Task<BcResult> SendAsync(object productId, object imageId, CancellationToken cancellationToken) =>
        Api.DeleteAsync(BcEndpoint.ProductImagesV3(productId, imageId), Filter, Options, cancellationToken);
}