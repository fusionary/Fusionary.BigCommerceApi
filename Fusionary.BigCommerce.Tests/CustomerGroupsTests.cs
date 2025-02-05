using Fusionary.BigCommerce.Operations.Customers.CustomerGroups;

namespace Fusionary.BigCommerce.Tests;

public class CustomerGroupsTests : BcTestBase
{
    [Test]
    public async Task Can_Get_Customer_Groups_Async()
    {
        var api = Services.GetRequiredService<BcApiCustomerGroupGet>();

        var result = await api.GetAllAsync();

        DumpObject(result);

        if (result.Success)
        {
            Assert.Pass();   
        }
    }
    
    [Test]
    public async Task Can_Create_Customer_Group_Async()
    {
        var api = Services.GetRequiredService<BcApiCustomerGroupCreate>();

        var customerGroup = new BcCustomerGroupPost
        {
            Name = "Test Customer Group 10",
            CategoryAccess = new CategoryAccess()
            {
                Type = CategoryTypes.All
            },
            DiscountRules = [new DiscountRules
            {
                Type = DiscountTypes.Product,
                Method = DiscountRulesMethods.Percentage,
                Amount = 10,
                ProductId = 1083
            }]
        };

        var result = await api.CreateAsync(customerGroup);

        DumpObject(result);

        if (result.Name == customerGroup.Name)
        {
            Assert.Pass();   
        }
    }
    
    [Test]
    public async Task Can_Update_Customer_Group_Async()
    {
        var api = Services.GetRequiredService<BcApiCustomerGroupUpdate>();

        var customerGroup = new BcCustomerGroupPost
        {
            Name = "Update Customer Group",
            DiscountRules = [new DiscountRules
            {
                Type = DiscountTypes.Product,
                Method = DiscountRulesMethods.Percentage,
                Amount = 20,
                ProductId = 1083
            }]
        };

        var result = await api.UpdateAsync(10, customerGroup);

        DumpObject(result);

        if (result.Name == customerGroup.Name)
        {
            Assert.Pass();   
        }
    }
    
    [Test]
    public async Task Can_Delete_Customer_Group_Async()
    {
        var api = Services.GetRequiredService<BcApiCustomerGroupDelete>();

        var result = await api.DeleteAsync(10);

        DumpObject(result);

        if (result.Success)
        {
            Assert.Pass();   
        }
    }
}