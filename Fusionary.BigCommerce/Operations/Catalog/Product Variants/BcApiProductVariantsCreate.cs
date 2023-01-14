namespace Fusionary.BigCommerce.Operations;

public class BcApiProductVariantsCreate : BcRequestBuilder, IBcApiOperation
{
    public BcApiProductVariantsCreate(IBcApi api) : base(api)
    { }

    public Task<BcResultData<BcProductVariant>> SendAsync(
        BcProductVariantPost variant,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductVariant>(variant.ProductId, variant, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse>(
        int productId,
        object variant,
        CancellationToken cancellationToken = default
    ) =>
        Api.PostDataAsync<TResponse>(
            BcEndpoint.ProductVariantsV3(productId),
            variant,
            Filter,
            Options,
            cancellationToken
        );
}

public class BcProductVariantsImagesCreate : BcRequestBuilder
{
    public BcProductVariantsImagesCreate(IBcApi api) : base(api)
    { }

    /// <summary>
    /// Uploads an image to a product.
    /// </summary>
    /// <param name="productId">The product id</param>
    /// <param name="imageUpload">The image being uploaded</param>
    /// <param name="cancellationToken"></param>
    /// <example>
    ///     <code>
    /// var imageFile = await BcFile.ReadFromFileAsync(fileName);
    ///
    /// var response = await bcApi
    ///   .Products()
    ///   .CreateImage()
    ///   .SendAsync(productId, imageFile);
    /// </code>
    /// </example>
    public Task<BcResultData<BcProductImage>> SendAsync(
        int productId,
        BcFile imageUpload,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductImage>(productId, imageUpload, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        int productId,
        BcFile imageUpload,
        CancellationToken cancellationToken = default
    )
    {
        var result = await Api.PostFormAsync<T, BcMetadataEmpty>(
            BcEndpoint.ProductImagesV3(productId),
            new MultipartFormDataContent
            {
                { new ByteArrayContent(imageUpload.Contents), "image_file", imageUpload.FileName }
            },
            Filter,
            Options,
            cancellationToken
        );

        return result.AsDataResult();
    }

    public Task<BcResultData<BcProductImage>> SendAsync(
        BcProductImagePost productImage,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductImage>(productImage.ProductId, productImage, cancellationToken);

    public Task<BcResultData<TResponse>> SendAsync<TResponse>(
        int productId,
        object? productImage,
        CancellationToken cancellationToken = default
    ) =>
        Api.PostDataAsync<TResponse>(
            BcEndpoint.ProductImagesV3(productId),
            productImage,
            Filter,
            Options,
            cancellationToken
        );
}