using Bogus.DataSets;

using Fusionary.BigCommerce.Utils;

using Microsoft.AspNetCore.Http;

namespace Fusionary.BigCommerce.Tests;

public class ImagineLearningTests: BcTestBase
{
    private readonly BigCommerceConfig _config = new()
    {
        StoreHash = "laf2hutq40",
        AccessToken = "87o9e2ja3pnb1vmvtf6c6tk5qpulasa",
        StorefrontUrl = "https://api.bigcommerce.com"
    };

    public ImagineLearningTests(ITestOutputHelper outputHelper) : base(outputHelper)
    {
    }

    [Fact]
    public async Task TestAsync()
    {
        var cancellationToken = CancellationToken.None;

     var apiClient = BigCommerceClient.Create(_config);

     var bc = BcApi.Create(apiClient);

     var results = await bc.GetPagedAsync<dynamic>("v3/catalog/trees", QueryString.Empty, cancellationToken: cancellationToken);

     DumpObject(BcJsonUtil.Serialize(results));

     if (1 == int.Parse("1"))
     {
         return;
     }

     foreach (var category in ILData.GetCategories())
     {
         var bcCategory = new BcCategoryPost
         {
             ParentId = 0,
             Name = category.Name,
             IsVisible = category.Status == "A",
         };

         var createdCategory = await bc.Catalog()
             .Category()
             .Create()
             .SendAsync(bcCategory, cancellationToken);

         var createdCategoryId = createdCategory.Data.Id;

         var metadataField = new BcMetafieldPost
         {
             Key = "Code",
             Value = category.Code,
             Description = "The code for the category",
             Namespace = "IL",
             PermissionSet = BcPermissionSet.Read
         };

         await bc.Catalog().CategoryMetafields().Create().SendAsync(createdCategoryId, metadataField, cancellationToken);
     }
    }
}
