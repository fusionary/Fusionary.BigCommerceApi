using Fusionary.BigCommerce.Utils;

namespace Fusionary.BigCommerce.Tests;

public class OrderTests : BcTestBase
{
    public OrderTests(ITestOutputHelper outputHelper) : base(outputHelper)
    { }

    [Fact]
    public async Task Can_Create_Order_Metafields_Async()
    {
        var orderMetafieldsApi = Services.GetRequiredService<BcApiOrderMetafields>();

        var cancellationToken = CancellationToken.None;

        var result = await orderMetafieldsApi
            .Create()
            .SendAsync(
                100,
                BcPermissionSet.Read,
                Faker.Hacker.Noun(),
                new[]
                {
                    new BcMetafieldItem { Key = Faker.Hacker.Noun(), Value = Faker.Hacker.Phrase() },
                    new BcMetafieldItem { Key = Faker.Hacker.Noun(), Value = Faker.Hacker.Phrase() }
                },
                cancellationToken
            );

        DumpObject(result);
    }

    [Fact]
    public async Task Can_Get_Product_Modifiers_Async()
    {
        var bc = Services.GetRequiredService<IBcApi>();

        var cancellationToken = CancellationToken.None;

        var result = await bc.Catalog().ProductModifiers().GetAll().SendAsync(363681, cancellationToken);


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
    public async Task Can_Create_Sample_Order_Async()
    {
        var createOrdersApi = Services.GetRequiredService<BcApiOrdersCreate>();

        var cancellationToken = CancellationToken.None;

        var newOrder = new BcOrderPost
        {
            BillingAddress = new BcBillingAddressBase
            {
                FirstName = Faker.Name.FirstName(),
                LastName = Faker.Name.LastName(),
                Street1 = Faker.Address.StreetAddress(),
                City = Faker.Address.City(),
                State = Faker.Address.State(),
                Zip = Faker.Address.ZipCode(),
                CountryIso2 = "US",
                Email = Faker.Internet.Email(),
                Phone = Faker.Phone.PhoneNumber(),
                Company = Faker.Company.CompanyName()
            },
            Products = new List<BcOrderCatalogProductPost>
            {
                new() { Quantity = Faker.Random.Int(0, 10), ProductId = 114 }
            }
        };

        var result = await createOrdersApi.SendAsync(newOrder, cancellationToken);

        Assert.NotNull(result);
        Assert.True(result.Success);
    }

    [Fact]
    public async Task Can_Update_Sample_Order_Async()
    {
        var updateOrdersApi = Services.GetRequiredService<BcApiOrdersUpdate>();

        var cancellationToken = CancellationToken.None;

        var orderToUpdate = new BcOrderPut
        {
            StatusId = BcOrderStatus.Completed
        };

        var result = await updateOrdersApi.SendAsync<BcOrderResponseFull>(150, orderToUpdate, cancellationToken);

        DumpObject(result);

        Assert.NotNull(result);
        Assert.True(result.Success);
    }


   
    [Fact]
    public async Task Can_Get_Cart_Async()
    {
        var bc = Services.GetRequiredService<IBcApi>();

        var cancellationToken = CancellationToken.None;

        var result = await bc
            .Carts()
            .Cart().Get().SendAsync("472abc00-7343-4e5a-9c31-d4f0276093d9", cancellationToken);
             
             

        DumpObject(result);

        Assert.NotNull(result);
        Assert.True(result.Success);

       
    }
    [Fact]
    public async Task Can_Delete_Cart_Line_Async()
    {
        var bc = Services.GetRequiredService<IBcApi>();

        var cancellationToken = CancellationToken.None;

        var result = await bc
            .Carts()
            .Cart().DeleteLineItem().SendAsync("472abc00-7343-4e5a-9c31-d4f0276093d9", "794e2dce-ac8c-4e71-b586-978afe423381",cancellationToken);



        DumpObject(result);
         
        Assert.True(true);


    }

    [Fact]
    public async Task Can_Get_All_Orders_Async()
    {
        var bc = Services.GetRequiredService<IBcApi>();

        var cancellationToken = CancellationToken.None;

        var result = await bc
            .Orders()
            .Order()
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
            .OrderMetafields()
            .GetAll()
            .Limit(10)
            .SendAsync(100, cancellationToken);

        if (result)
        {
            foreach (var metafield in result.Data)
            {
                DumpObject(metafield);

                await bc.Orders().OrderMetafields().Delete().SendAsync(100, metafield.Id, cancellationToken);
            }
        }
    }

    [Fact]
    public void Can_SerializeOrder()
    {
        var order = new BcOrderPost
        {
            BillingAddress =
                new BcBillingAddressBase { Company = Faker.Company.CompanyName(), Zip = Faker.Address.ZipCode() },
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