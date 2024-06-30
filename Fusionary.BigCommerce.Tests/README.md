# BigCommerce Unit Tests

To run test, save your StoreHash and Access Token in user-secrets:

```
dotnet user-secrets set "BigCommerce:StoreHash" "12345"
dotnet user-secrets set "BigCommerce:AccessToken" "1845633E-S3CR3TS-8364B7FBE3A2"
dotnet user-secrets set "BigCommerce:StorefrontUrl" "https://mystore.bigcommerce.com"
dotnet user-secrets set "BigCommerce:StorefrontChannelId" "1"
dotnet user-secrets set "BigCommerce:StorefrontAccessToken" "1845633E-S3CR3TS-8364B7FBE3A2"
```

Storefront values are only needed for Storefront GraphQL APIs.
