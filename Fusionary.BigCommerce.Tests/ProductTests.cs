namespace Fusionary.BigCommerce.Tests;

public class ProductTests : BcTestBase
{
    public ProductTests(ITestOutputHelper outputHelper) : base(outputHelper)
    { }

    [Fact]
    public async Task Can_Get_All_Products_Async()
    {
        var productApi = Services.GetRequiredService<BcApiProduct>();

        var cancellationToken = CancellationToken.None;

        var response = await productApi
            .Search()
            .Availability(BcAvailability.Available)
            .Include(BcProductInclude.Variants, BcProductInclude.Images, BcProductInclude.CustomFields)
            .Limit(25)
            .Sort(BcProductSort.Name)
            .SendAsync(cancellationToken);

        if (response)
        {
            var (data, pagination) = response;

            LogMessage($"Total from first page: {pagination.Total}");

            if (response.HasNextPage)
            {
                var remainingItems = await GetRemainingDataAsync(productApi, pagination, cancellationToken);

                data.AddRange(remainingItems);
            }

            LogMessage($"Total Items: {data.Count}");

            Assert.Equal(pagination.Total, data.Count);
        }
    }

    [Fact]
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

        Assert.NotNull(product);

        var id           = product.Id;
        var name         = product.Name;
        var price        = product.Price;
        var customFields = product.CustomFields;

        var customValues = customFields is not null
            ? string.Join(", ", customFields.Select(x => $"{x.Name}:{x.Value}"))
            : default;

        LogMessage($"{id} | {name} | {price} | {customValues}");
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
        } while (nextPage?.HasNextPage == true);

        return remainingItems;
    }
}