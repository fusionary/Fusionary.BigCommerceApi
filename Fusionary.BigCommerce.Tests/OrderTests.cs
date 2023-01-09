using Fusionary.BigCommerce.Utils;

namespace Fusionary.BigCommerce.Tests;

public class OrderTests : BcTestBase
{
    public OrderTests(ITestOutputHelper outputHelper) : base(outputHelper)
    { }

    [Fact]
    public async Task Can_Create_Order_Metafields_Async()
    {
        var bc = Services.GetRequiredService<IBcApi>();

        var cancellationToken = CancellationToken.None;

        var result = await bc
            .Orders()
            .CreateMetafields()
            .SendAsync(
                100,
                BcPermissionSet.Read,
                "Testing",
                new[]
                {
                    new BcMetafieldItem { Key = "Test", Value = "Test" },
                    new BcMetafieldItem { Key = "Test2", Value = "Test2" }
                },
                cancellationToken
            );

        DumpObject(result);
    }

    [Fact]
    public async Task Can_Get_All_Orders_Async()
    {
        var bc = Services.GetRequiredService<IBcApi>();

        var cancellationToken = CancellationToken.None;

        var result = await bc
            .Orders()
            .Search()
            .Limit(1)
            .MinDateCreated(DateTime.Today.AddDays(-14))
            .Sort(BcOrderSort.DateCreated)
            .SendAsync(cancellationToken);

        DumpObject(result);

        Assert.NotNull(result);
        Assert.True(result.Success);

        if (result.HasData)
        {
            foreach (var order in result.Data)
            {
                DumpObject(order);
            }
        }
    }

    [Fact]
    public async Task Can_Get_Order_Metafields_Async()
    {
        var bc = Services.GetRequiredService<IBcApi>();

        var cancellationToken = CancellationToken.None;

        var result = await bc
            .Orders()
            .GetAllMetafields()
            .Limit(10)
            .SendAsync(100, cancellationToken);

        if (result)
        {
            foreach (var metafield in result.Data)
            {
                DumpObject(metafield);

                await bc.Orders().DeleteMetafield().SendAsync(100, metafield.Id, cancellationToken);
            }
        }
    }

    [Fact]
    public void Can_SerializeOrder()
    {
        var order = new BcOrderPost
        {
            BillingAddress = new BcBillingAddressBase { Company = "Fusionary", Zip = "49501" },
            Products = new List<BcOrderCatalogProductPost>
            {
                new() { ProductId = 1, Quantity = 1, PriceExTax = 5.00m },
                new()
                {
                    ProductId = 2,
                    Quantity = 2,
                    ProductOptions = new List<BcProductOptions> { new() { Id = 27, Value = "Red" } }
                }
            }
        };

        var json = BcJsonUtil.Serialize(order, true);

        Logger.WriteLine(json);
    }
}