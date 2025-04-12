namespace Fusionary.BigCommerce.Tests;

public class ImageTests : BcTestBase
{
    [Test]
    public async Task Can_Get_Product_Images_By_Id_Async()
    {
        var productImagesApi = Services.GetRequiredService<BcApiProductImages>();

        var response = await productImagesApi
            .Get()
            .SendAsync(119);

        DumpObject(response);

        foreach (var img in response.Data)
        {
            var id  = img.Id;
            var url = img.UrlStandard;
            var alt = img.Description;

            LogMessage($"{id} | {url} | {alt}");
        }
    }

    [Test]
    public async Task Can_Upload_Image_Async()
    {
        var productImagesApi = Services.GetRequiredService<BcApiProductImages>();

        const string fileName = "logo.png";

        const int productId = 119;
        var       imageFile = await BcFile.ReadFromFileAsync(fileName);

        var response = await productImagesApi
            .Create()
            .SendAsync(productId, imageFile);

        var createdImage = response.Data;

        var updatedImage = new BcProductImagePut
        {
            ProductId = createdImage.ProductId, Id = createdImage.Id, Description = "Test"
        };

        var updateResponse = await productImagesApi
            .Update()
            .SendAsync(updatedImage);

        DumpObject(updateResponse);

        var deletedResponse = await productImagesApi
            .Delete()
            .SendAsync(createdImage.ProductId, createdImage.Id);

        DumpObject(deletedResponse);
    }
}