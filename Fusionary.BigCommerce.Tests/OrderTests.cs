using Fusionary.BigCommerce.Utils;

namespace Fusionary.BigCommerce.Tests;

public class OrderTests : BcTestBase
{
    public OrderTests(ITestOutputHelper outputHelper) : base(outputHelper)
    { }

    [Fact]
    public async Task Can_Get_All_Orders_Async()
    {
        var bc = Services.GetRequiredService<Bc>();

        var cancellationToken = CancellationToken.None;

        var result = await bc
            .Orders()
            .Search()
            .Limit(5)
            .Sort(BcOrderSort.DateCreated)
            .SendAsync(cancellationToken);

        Assert.NotNull(result);
        Assert.True(result.Success);

        foreach (var order in result.Data)
        {
            var id     = order.Id;
            var status = order.Status;
            var total  = order.TotalExTax;

            LogMessage($"{id} | {status} | {total}");
        }
    }

    [Fact]
    public async Task Can_Get_Order_Metafields_Async()
    {
        var bc = Services.GetRequiredService<Bc>();

        var cancellationToken = CancellationToken.None;

        var result = await bc
            .Orders()
            .GetMetafields()
            .Limit(5)
            .SendAsync(100, cancellationToken);

        if (result)
        {
            foreach (var order in result.Data)
            {
                DumpObject(order);
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