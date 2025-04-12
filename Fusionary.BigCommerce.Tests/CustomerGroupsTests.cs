namespace Fusionary.BigCommerce.Tests;

public class CustomerGroupsTests : BcTestBase
{
    [Test]
    public async Task Can_Create_Customer_Group_Async()
    {
        var api = Services.GetRequiredService<BcApiCustomerGroupCreate>();

        var customerGroup = new BcCustomerGroupPost
        {
            Name = "Test Customer Group 13",
            CategoryAccess = new BcCategoryAccess { Type = BcCategoryTypes.All },
            DiscountRules =
            [
                new BcDiscountRules
                {
                    Type = BcDiscountTypes.Product,
                    Method = BcDiscountRulesMethods.Percentage,
                    Amount = 10,
                    ProductId = 1083
                }
            ]
        };

        var result = await api.SendAsync(customerGroup);

        DumpObject(result);

        if (result.Success)
        {
            Assert.Pass();
        }

        Assert.Fail();
    }

    [Test]
    public async Task Can_Delete_Customer_Group_Async()
    {
        var api = Services.GetRequiredService<BcApiCustomerGroupDelete>();

        const int id = 24;

        var result = await api.DeleteAsync(id);

        DumpObject(result);

        if (result.Success)
        {
            Assert.Pass();
        }

        Assert.Fail();
    }

    [Test]
    public async Task Can_Get_Customer_Group_Async()
    {
        var api = Services.GetRequiredService<BcApiCustomerGroupGet>();

        const int id = 24;

        var result = await api.SendAsync(id);

        DumpObject(result);

        if (result.Success)
        {
            Assert.Pass();
        }

        Assert.Fail();
    }

    [Test]
    public async Task Can_Get_Customer_Groups_Async()
    {
        var api = Services.GetRequiredService<BcApiCustomerGroupGetAll>();

        var result = await api.SendAsync();

        DumpObject(result);

        if (result.Success)
        {
            Assert.Pass();
        }

        Assert.Fail();
    }

    [Test]
    public async Task Can_Update_Customer_Group_Async()
    {
        var api = Services.GetRequiredService<BcApiCustomerGroupUpdate>();

        const int id = 24;

        var customerGroup = new BcCustomerGroupPost
        {
            Name = "Update Customer Group",
            DiscountRules =
            [
                new BcDiscountRules
                {
                    Type = BcDiscountTypes.Product,
                    Method = BcDiscountRulesMethods.Percentage,
                    Amount = 20,
                    ProductId = 1083
                }
            ]
        };

        var result = await api.SendAsync(id, customerGroup);

        DumpObject(result);

        if (result.Success)
        {
            Assert.Pass();
        }

        Assert.Fail();
    }
}