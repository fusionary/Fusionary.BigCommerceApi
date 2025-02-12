using Fusionary.BigCommerce.Operations.Customers;

namespace Fusionary.BigCommerce.Tests;

public class CustomerTests : BcTestBase
{   
    [Test]
    public async Task Can_Get_Customer_Async()
    {
        var api = Services.GetRequiredService<BcApiCustomerGet>();
        
        const int id = 1; // Replace with a valid customer ID

        var result = await api.SendAsync(id);

        DumpObject(result);

        if (result.Success)
        {
            Assert.Pass();   
        }
        Assert.Fail();
    }
}
