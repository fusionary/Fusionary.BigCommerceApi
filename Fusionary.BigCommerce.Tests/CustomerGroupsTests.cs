using Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

namespace Fusionary.BigCommerce.Tests;

public class CustomerGroupsTests : BcTestBase
{
    [Test]
    public async Task Can_Get_Customer_Groups_Async()
    {
        var api = Services.GetRequiredService<BcApiCustomerGroupGet>();

        var result = await api.GetAsync();

        DumpObject(result);

        Assert.Pass();
    }
}