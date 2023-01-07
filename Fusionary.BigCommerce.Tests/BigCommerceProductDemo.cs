namespace Fusionary.BigCommerce.Tests;

public class BigCommerceProductDemo {

    private readonly IBcApi _bcApi;

    public BigCommerceProductDemo(IBcApi bcApi) {
        _bcApi = bcApi;
    }

    public async Task DisplayFiveProductsAsync(CancellationToken cancellationToken)
    {
        var response = await _bcApi
            .Products()
            .Search()
            .Availability(BcAvailability.Available)
            .Include(BcProductInclude.Variants, BcProductInclude.Images, BcProductInclude.CustomFields)
            .Limit(5)
            .Sort(BcProductSort.Name)
            .SendAsync(cancellationToken);

        if (response.HasError)
        {
            var error = response.Error;

            Console.WriteLine($"Error: {error.Status} | {error.Title} | {error.Type}");

            if (error.HasErrorDetails)
            {
                foreach (var (key, value) in error.ErrorDetails)
                {
                    Console.WriteLine($"{key}: {value}");
                }
            }

            return;
        }

        var (products, pagination) = response;

        Console.WriteLine($"Page {pagination.CurrentPage} of {pagination.TotalPages} ({pagination.Total})");

        foreach (var product in products)
        {
            var id    = product.Id;
            var name  = product.Name;
            var price = product.Price;

            Console.WriteLine($"{id} | {name} | {price}");
        }
    }
}