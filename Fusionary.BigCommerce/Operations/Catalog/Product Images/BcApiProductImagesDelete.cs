namespace Fusionary.BigCommerce.Operations;

public class BcApiProductImagesDelete(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResult> SendAsync(
        BcId productId,
        BcId imageId,
        CancellationToken cancellationToken = default
    ) =>
        Api.DeleteAsync(BcEndpoint.ProductImagesV3(productId, imageId), Filter, Options, cancellationToken);
}