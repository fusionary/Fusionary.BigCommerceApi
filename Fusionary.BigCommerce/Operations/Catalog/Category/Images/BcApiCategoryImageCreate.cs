namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryImageCreate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    /// <summary>
    /// Uploads an image for a category.
    /// </summary>
    /// <param name="categoryId">The category id</param>
    /// <param name="imageUpload">The image being uploaded</param>
    /// <param name="cancellationToken"></param>
    /// <example>
    ///     <code>
    /// var imageFile = await BcFile.ReadFromFileAsync(fileName);
    ///
    /// var response = await bcApi
    ///   .Category()
    ///   .Image()
    ///   .Create()
    ///   .SendAsync(productId, imageFile);
    /// </code>
    /// </example>
    public Task<BcResultData<BcProductImage>> SendAsync(
        BcId categoryId,
        BcFile imageUpload,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductImage>(categoryId, imageUpload, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        BcId categoryId,
        BcFile imageUpload,
        CancellationToken cancellationToken = default
    )
    {
        var result = await Api.PostFormAsync<T, BcMetadataEmpty>(
            BcEndpoint.CategoryImagesV3(categoryId),
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
}