using Fusionary.BigCommerce.Operations;
using Fusionary.BigCommerce.Types;

using Microsoft.Extensions.DependencyInjection;

using Xunit.Abstractions;

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

        foreach (var product in response.Data)
        {
            var id    = product.Id;
            var name  = product.GetValue("name");
            var price = product.GetValue<decimal>("price");

            LogMessage($"{id} | {name} | {price}");
        }

        Assert.True(response.Data.Count > 0);
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

        Assert.NotNull(product);

        var id           = product.Id;
        var name         = product.GetValue("name");
        var price        = product.GetValue<decimal>("price");
        var customFields = product.GetValue<BcCustomField[]>("custom_fields");

        var customValues = string.Join(", ", customFields.Select(x => $"{x.Name}:{x.Value}"));

        LogMessage($"{id} | {name} | {price} | {customValues}");
    }
}