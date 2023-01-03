# Fusionary.BigCommerceApi

c# BigCommerce Api for DotNet

## Installation

Add env variables to your project:

```
dotnet user-secrets set "BigCommerce:StoreHash" "12345"
dotnet user-secrets set "BigCommerce:AccessToken" "1845633E-S3CR3TS-8364B7FBE3A2"
```

or in appSettings.json:

```json
{
  "BigCommerce": {
    "Host": "https://api.bigcommerce.com",
    "StoreHash": "12345",
    "AccessToken": "1845633E-S3CR3TS-8364B7FBE3A2"
  }
}
```

Register BigCommerceApi in your Startup.cs:

```csharp
services.AddBigCommerce(configuration);
```

## Usage

```csharp

public class BigCommerceProductDemo {

    private readonly Bc _bc;
    
    public BigCommerceProductDemo(Bc bc) {
        _bc = bc;
    }

    public async Task DisplayFiveProductsAsync(CancellationToken cancellationToken)
    {
        return await _bc
            .Products()
            .Search()
            .Availability(BcAvailability.Available)
            .Include(BcProductInclude.Variants, BcProductInclude.Images, BcProductInclude.CustomFields)
            .Limit(5)
            .Sort(BcProductSort.Name)
            .SendAsync(cancellationToken);

        foreach (var product in response.Data)
        {
            var id    = product.Id;
            var name  = product.GetValue("name");
            var price = product.GetValue<decimal>("price");

            Console.WriteLine($"{id} | {name} | {price}");
        }
    }
}
```

```csharp
var config = new BigCommerceConfig {
   StoreHash = "12345",
   AccessToken = "1845633E-S3CR3TS-8364B7FBE3A2"
});

IBigCommerceApi apiClient = BigCommerceClient.Create(config);

// Raw API
var response = await apiClient
    .GetAsync(
        "v3/catalog/products", 
        QueryString.Create("limit", "10"), 
        cancellationToken);

// Fluent API
var bc = new Bc(apiClient);

var response = await bc
    .Products()
    .Get()
    .Include(BcProductInclude.Variants, BcProductInclude.Images, BcProductInclude.CustomFields)
    .SendAsync(199, cancellationToken);

```
