namespace Fusionary.BigCommerce.Tests;

public class PriceListTests : BcTestBase
{
    [Test]
    public async Task Can_Upsert_PriceList_Record_Async()
    {
        var api = Services.GetRequiredService<BcApiPriceListRecordUpsert>();

        var result = await api.SendAsync(
            1,
            [
                new BcPriceListRecordUpsert { Sku = "829_AX", Price = 72.00m, Currency = "usd" }
            ],
            CancellationToken.None
        );

        DumpObject(result);

        Assert.Pass();
    }
}