namespace Fusionary.BigCommerce.Tests;

public class OrderTests : BcTestBase
{
    [Test]
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
                [
                    new BcMetafieldItem { Key = Faker.Hacker.Noun(), Value = Faker.Hacker.Phrase() },
                    new BcMetafieldItem { Key = Faker.Hacker.Noun(), Value = Faker.Hacker.Phrase() }
                ],
                cancellationToken
            );

        DumpObject(result);

        Assert.Pass();
    }

    [Test]
    public async Task Can_Create_Order_Shipment_Async()
    {
        var bc = Services.GetRequiredService<IBcApi>();

        var cancellationToken = CancellationToken.None;

        var result = await bc
            .Orders()
            .OrderShipments()
            .Create()
            .SendAsync(
                108,
                new BcOrderShipmentsPost
                {
                    TrackingNumber = Faker.Random.AlphaNumeric(10),
                    ShippingProvider = "shipperhq",
                    OrderAddressId = 9,
                    Items = new List<BcOrderShipmentsItem> { new() { OrderProductId = 9, Quantity = 1 } }
                },
                cancellationToken
            );

        DumpObject(result);

        result.Success.Should().BeTrue();

        Assert.Pass();
    }

    [Test]
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

        result.Success.Should().BeTrue();
    }

    [Test]
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

        result.Success.Should().BeTrue();

        if (result.HasData)
        {
            foreach (var order in result.Data)
            {
                DumpObject(order);
            }
        }

        Assert.Pass();
    }

    [Test]
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

        Assert.Pass();
    }

    [Test]
    public async Task Can_Get_Order_Shipping_Async()
    {
        var bc = Services.GetRequiredService<IBcApi>();

        var cancellationToken = CancellationToken.None;

        var result = await bc
            .Orders()
            .OrderShipping()
            .Get()
            .SendAsync(106, cancellationToken);

        DumpObject(result);

        result.Success.Should().BeTrue();

        Assert.Pass();
    }

    [Test]
    public async Task Can_Get_Order_With_Consignments_Async()
    {
        var bc = Services.GetRequiredService<IBcApi>();

        var cancellationToken = CancellationToken.None;

        var result = await bc
            .Orders()
            .Order()
            .GetWithConsignments()
            .SendAsync(106, cancellationToken);

        DumpObject(result);

        result.Success.Should().BeTrue();

        Assert.Pass();
    }

    [Test]
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

        DumpObject(order);

        Assert.Pass();
    }

    [Test]
    public async Task Can_Update_Sample_Order_Async()
    {
        var updateOrdersApi = Services.GetRequiredService<BcApiOrdersUpdate>();

        var cancellationToken = CancellationToken.None;

        var orderToUpdate = new BcOrderPut { StatusId = BcOrderStatus.Completed };

        var result = await updateOrdersApi.SendAsync<BcOrderResponseFull>(150, orderToUpdate, cancellationToken);

        DumpObject(result);

        result.Success.Should().BeTrue();
    }
}