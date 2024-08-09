# Fusionary.BigCommerceApi

c# BigCommerce Api for DotNet

## Installation

Add env variables to your project:

```
dotnet user-secrets set "BigCommerce:StoreHash" "12345"
dotnet user-secrets set "BigCommerce:AccessToken" "1845633E-S3CR3TS-8364B7FBE3A2"
dotnet user-secrets set "BigCommerce:StorefrontUrl" "https://mystore.bigcommerce.com"
dotnet user-secrets set "BigCommerce:StorefrontChannelId" "1"
dotnet user-secrets set "BigCommerce:StorefrontAccessToken" "1845633E-S3CR3TS-8364B7FBE3A2"
```

or in appSettings.json:

```json
{
  "BigCommerce": {
    "Host": "https://api.bigcommerce.com",
    "StoreHash": "12345",
    "AccessToken": "1845633E-S3CR3TS-8364B7FBE3A2",
    "StorefrontUrl": "https://mystore.bigcommerce.com",
    "StorefrontChannelId": "1",
    "StorefrontAccessToken": "1845633E-S3CR3TS-8364B7FBE3A2"
  }
}
```

**Storefront** config values are only needed for Storefront GraphQL APIs.

-----

Register BigCommerceApi in your Startup.cs:

```csharp
services.AddBigCommerce(configuration);
```

## Usage

```csharp
public class BigCommerceProductDemo {

    private readonly IBcApi _bcApi;

    public BigCommerceProductDemo(IBcApi bcApi) {
        _bcApi = bcApi;
    }

    public async Task DisplayFiveProductsAsync(CancellationToken cancellationToken = default)
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
```

```csharp
var config = new BigCommerceConfig {
   StoreHash = "12345",
   AccessToken = "1845633E-S3CR3TS-8364B7FBE3A2",
   // Only needed for Storefront GraphQL API
   StorefrontChannelId = 1,
   StorefrontUrl = "https://mystore.bigcommerce.com"
});

IBigCommerceApi apiClient = BigCommerceClient.Create(config);

// Raw API
var response = await apiClient
    .GetAsync(
        "v3/catalog/products", 
        QueryString.Create("limit", "10"), 
        cancellationToken);

// Fluent API
var bc = BcApi.Create(apiClient);

var response = await bc
    .Products()
    .Get()
    .Include(BcProductInclude.Variants, BcProductInclude.Images, BcProductInclude.CustomFields)
    .SendAsync(199, cancellationToken);
    
    
// Storefront GraphQL Client
var graphQL = services.GetRequiredService<IBcStorefrontGraphQL>();

        var request = new GraphQLRequest(@"
query paginateProducts {
  site {
    search {
      searchProducts(
        filters: {
        	productAttributes: [
            {
              attribute: ""Color"", values: ""Red""
            }
          ]
        }
      ) {
        products {
          edges {
            node {
              name
              sku
            }
          }
        }
      }
    }
  }
}
");
        var response = await graphQL
            .SendQueryAsync<dynamic>(request, cancellationToken);
            
        Console.WriteLine(JsonSerializer.Serialize(response.Data));

```
