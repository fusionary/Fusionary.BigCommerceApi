namespace Fusionary.BigCommerce.Tests;

public class ProductTests : BcTestBase
{
    public ProductTests(ITestOutputHelper outputHelper) : base(outputHelper)
    { }

    [Fact]
    public async Task Can_Get_All_Products_Async()
    {
        var bc = Services.GetRequiredService<IBcApi>();

        var cancellationToken = CancellationToken.None;

        var response = await bc
            .Products()
            .Search()
            .Availability(BcAvailability.Available)
            .Include(BcProductInclude.Variants, BcProductInclude.Images, BcProductInclude.CustomFields)
            .Limit(2)
            .Sort(BcProductSort.Name)
            .SendAsync(cancellationToken);

        if (response)
        {
            var (data, pagination) = response;

            LogMessage($"Total from first page: {pagination.Total}");

            if (response.HasNextPage)
            {
                var remainingItems = await GetRemainingDataAsync(bc, pagination, cancellationToken);

                data.AddRange(remainingItems);
            }

            LogMessage($"Total Items: {data.Count}");

            Assert.Equal(pagination.Total, data.Count);
        }
    }

    [Fact]
    public async Task Can_Get_Product_By_Id_Async()
    {
        var bc = Services.GetRequiredService<IBcApi>();

        var cancellationToken = CancellationToken.None;

        var response = await bc
            .Products()
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
        IBcApi bc,
        BcPagination pagination,
        CancellationToken cancellationToken
    )
    {
        var remainingItems = new List<BcProductFull>();

        BcResultPaged<BcProductFull>? nextPage = null;

        do
        {
            var nextPagination = nextPage?.Pagination ?? pagination;

            nextPage = await bc
                .Products()
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