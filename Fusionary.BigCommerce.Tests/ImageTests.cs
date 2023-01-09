namespace Fusionary.BigCommerce.Tests;

public class ImageTests : BcTestBase
{
    public ImageTests(ITestOutputHelper outputHelper) : base(outputHelper)
    { }

    [Fact]
    public async Task Can_Get_Product_Images_By_Id_Async()
    {
        var bc = Services.GetRequiredService<IBcApi>();

        var cancellationToken = CancellationToken.None;

        var response = await bc
            .Products()
            .GetImages()
            .SendAsync(119, cancellationToken);

        DumpObject(response);

        foreach (var img in response.Data)
        {
            var id  = img.Id;
            var url = img.UrlStandard;
            var alt = img.Description;

            LogMessage($"{id} | {url} | {alt}");
        }
    }

    [Fact]
    public async Task Can_Upload_Image_Async()
    {
        var bcApi = Services.GetRequiredService<IBcApi>();

        var cancellationToken = CancellationToken.None;

        const string fileName = "logo.png";

        const int productId = 119;
        var       imageFile = await BcFile.ReadFromFileAsync(fileName, cancellationToken);

        var response = await bcApi
            .Products()
            .CreateImage()
            .SendAsync(productId, imageFile, cancellationToken);

        var createdImage = response.Data;

        var updatedImage = new BcProductImagePut
        {
            ProductId = createdImage.ProductId, Id = createdImage.Id, Description = "Test"
        };

        var updateResponse = await bcApi
            .Products()
            .UpdateImage()
            .SendAsync(updatedImage, cancellationToken);

        DumpObject(updateResponse);

        var deletedResponse = await bcApi
            .Products()
            .DeleteImage()
            .SendAsync(createdImage.ProductId, createdImage.Id, cancellationToken);

        DumpObject(deletedResponse);
    }
}