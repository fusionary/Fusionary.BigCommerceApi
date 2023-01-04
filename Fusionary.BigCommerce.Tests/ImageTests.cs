namespace Fusionary.BigCommerce.Tests;

public class ImageTests : BcTestBase
{
    public ImageTests(ITestOutputHelper outputHelper) : base(outputHelper)
    { }

    [Fact]
    public async Task Can_Get_Product_By_Id_Async()
    {
        var bc = Services.GetRequiredService<Bc>();

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
}