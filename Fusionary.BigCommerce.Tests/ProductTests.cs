using System.Text.Json.Serialization;

namespace Fusionary.BigCommerce.Tests;

public class ProductTests : BcTestBase
{
    [Test]
    public async Task Can_Get_All_Products_Async()
    {
        var productApi = Services.GetRequiredService<BcApiProduct>();

        var cancellationToken = Cts.Token;

        var response = await productApi
            .Search()
            .ChannelId(1404663)
            .Availability(BcAvailability.Available)
            .Include(BcProductInclude.Variants, BcProductInclude.Images, BcProductInclude.CustomFields)
            .Limit(25)
            .Sort(BcProductSort.Name)
            .SendAsync(cancellationToken);

        if (!response)
        {
            DumpObject(response.Error);
            Assert.Fail();
            return;
        }

        var (data, pagination) = response;

        LogMessage($"Total from first page: {pagination.Total}");

        if (response.HasNextPage)
        {
            var remainingItems = await GetRemainingDataAsync(productApi, pagination, cancellationToken);

            data.AddRange(remainingItems);
        }

        LogMessage($"Total Items: {data.Count}");

        data.Count.Should().Be(pagination.Total);

        DumpObject(data);

        Assert.Pass();
    }

    public record BcSku
    {
        [JsonPropertyName("id")]
        public BcId Id { get; init; } = string.Empty;
        
        [JsonPropertyName("sku")]
        public string Sku { get; init; } = string.Empty;
    }

    [Test]
    public async Task Can_Get_All_Products_Skus_Async()
    {
        var productApi = Services.GetRequiredService<BcApiProduct>();

        var cancellationToken = Cts.Token;

        var response = await productApi
            .Search()
            .IncludeFields("sku")
            .SendAsync<BcSku>(cancellationToken);

        if (!response)
        {
            DumpObject(response.Error);
            Assert.Fail();
            return;
        }

        DumpObject(response.Data);

        Assert.Pass();
    }

    [Test]
    public async Task Can_Get_Product_By_Id_Async()
    {
        var bcProductApi = Services.GetRequiredService<BcApiProduct>();

        var cancellationToken = CancellationToken.None;

        var response = await bcProductApi
            .Get()
            .Include(BcProductInclude.Variants, BcProductInclude.Images, BcProductInclude.CustomFields)
            .SendAsync(81, cancellationToken);

        var product = response.Data;

        DumpObject(response);

        product.Should().NotBeNull();

        var id           = product.Id;
        var name         = product.Name;
        var price        = product.Price;
        var customFields = product.CustomFields;

        var customValues = customFields is not null
            ? string.Join(", ", customFields.Select(x => $"{x.Name}:{x.Value}"))
            : default;

        LogMessage($"{id} | {name} | {price} | {customValues}");

        Assert.Pass();
    }

    private static async Task<List<BcProductFull>> GetRemainingDataAsync(
        BcApiProduct productApi,
        BcPagination pagination,
        CancellationToken cancellationToken = default
    )
    {
        var remainingItems = new List<BcProductFull>();

        BcResultPaged<BcProductFull>? nextPage = null;

        do
        {
            var nextPagination = nextPage?.Pagination ?? pagination;

            nextPage = await productApi
                .Search()
                .Next(nextPagination)
                .SendAsync(cancellationToken);

            if (nextPage.HasData)
            {
                remainingItems.AddRange(nextPage.Data);
            }
        } while (nextPage is { HasNextPage: true });

        return remainingItems;
    }
}