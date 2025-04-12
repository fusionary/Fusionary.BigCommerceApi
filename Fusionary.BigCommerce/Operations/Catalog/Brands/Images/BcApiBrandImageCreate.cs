namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandImageCreate(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    /// <summary>
    /// Uploads an image for a brand.
    /// </summary>
    /// <param name="brandId">The brand id</param>
    /// <param name="imageUpload">The image being uploaded</param>
    /// <param name="cancellationToken"></param>
    /// <example>
    ///     <code>
    /// var imageFile = await BcFile.ReadFromFileAsync(fileName);
    ///
    /// var response = await bcApi
    ///   .Brand()
    ///   .Image()
    ///   .Create()
    ///   .SendAsync(productId, imageFile);
    /// </code>
    /// </example>
    public Task<BcResultData<BcProductImage>> SendAsync(
        BcId brandId,
        BcFile imageUpload,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<BcProductImage>(brandId, imageUpload, cancellationToken);

    public async Task<BcResultData<T>> SendAsync<T>(
        BcId brandId,
        BcFile imageUpload,
        CancellationToken cancellationToken = default
    )
    {
        var result = await Api.PostFormAsync<T, BcMetadataEmpty>(
            BcEndpoint.BrandImageV3(brandId),
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