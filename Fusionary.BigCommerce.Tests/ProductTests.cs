namespace Fusionary.BigCommerce.Tests;

public class ProductTests : BcTestBase
{
    public ProductTests(ITestOutputHelper outputHelper) : base(outputHelper)
    { }

    [Fact]
    public async Task Can_Get_All_Products_Async()
    {
        var bc = Services.GetRequiredService<Bc>();

        var cancellationToken = CancellationToken.None;

        var response = await bc
            .Products()
            .Search()
            .Availability(BcAvailability.Available)
            .Include(BcProductInclude.Variants, BcProductInclude.Images, BcProductInclude.CustomFields)
            .Limit(5)
            .Sort(BcProductSort.Name)
            .SendAsync(cancellationToken);

        if (response)
        {
            var (data, pagination) = response;

            DumpObject(pagination);

            foreach (var product in data)
            {
                DumpObject(product);
            }
        }
    }

    [Fact]
    public async Task Can_Get_Product_By_Id_Async()
    {
        var bc = Services.GetRequiredService<Bc>();

        var cancellationToken = CancellationToken.None;

        var response = await bc
            .Products()
            .Get()
            .Include(BcProductInclude.Variants, BcProductInclude.Images, BcProductInclude.CustomFields)
            .SendAsync(119, cancellationToken);

        var product = response.Data;

        DumpObject(response);

        Assert.NotNull(product);

        var id           = product.Id;
        var name         = product.GetValue("name");
        var price        = product.GetValue<decimal>("price");
        var customFields = product.GetValue<BcCustomField[]>("custom_fields");

        var customValues = string.Join(", ", customFields.Select(x => $"{x.Name}:{x.Value}"));

        LogMessage($"{id} | {name} | {price} | {customValues}");
    }
}