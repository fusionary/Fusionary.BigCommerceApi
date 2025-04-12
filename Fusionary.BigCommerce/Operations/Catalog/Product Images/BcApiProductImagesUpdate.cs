namespace Fusionary.BigCommerce.Operations;

public class BcApiProductImagesUpdate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcProductImage>> SendAsync(
        BcProductImagePut productImage,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductImage>(productImage.ProductId, productImage.Id, productImage, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        BcId productId,
        BcId imageId,
        object productImage,
        CancellationToken cancellationToken = default
    ) =>
        await Api.PutDataAsync<T>(
            BcEndpoint.ProductImagesV3(productId, imageId),
            productImage,
            Filter,
            Options,
            cancellationToken
        );
}