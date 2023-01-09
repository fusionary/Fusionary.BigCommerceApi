namespace Fusionary.BigCommerce.Operations;

public class BcProductImageUpdate : BcRequestBuilder
{
    public BcProductImageUpdate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcProductImage>> SendAsync(
        BcProductImagePut productImage,
        CancellationToken cancellationToken
    ) =>
        SendAsync<BcProductImage>(productImage.ProductId, productImage.Id, productImage, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        int productId,
        int imageId,
        object productImage,
        CancellationToken cancellationToken
    ) =>
        await Api.PutDataAsync<T>(
            BcEndpoint.ProductImagesV3(productId, imageId),
            productImage,
            Filter,
            Options,
            cancellationToken
        );
}