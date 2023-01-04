using GraphQL;

namespace Fusionary.BigCommerce.Tests;

public class StorefrontGraphQLTests: BcTestBase
{
    public StorefrontGraphQLTests(ITestOutputHelper outputHelper) : base(outputHelper)
    {

    }

    [Fact]
    public async Task Can_Query_GraphQL_Async()
    {
        var graphQL = Services.GetRequiredService<IBcStorefrontGraphQL>();

        var cancellationToken = CancellationToken.None;

        var request = new GraphQLRequest(@"
query paginateProducts {
  site {
    search {
      searchProducts(
        filters: {
        	productAttributes: [
            {
              attribute: ""Color"", values: ""Java""
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

        DumpObject(response.Data);
    }
}