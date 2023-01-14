namespace Fusionary.BigCommerce.Operations;

public class BcApiProductImagesDelete : BcRequestBuilder, IBcApiOperation
{
    public BcApiProductImagesDelete(IBcApi api) : base(api)
    { }

    public Task<BcResult> SendAsync(
        BcId productId,
        BcId imageId,
        CancellationToken cancellationToken = default
    ) =>
        Api.DeleteAsync(BcEndpoint.ProductImagesV3(productId, imageId), Filter, Options, cancellationToken);
}