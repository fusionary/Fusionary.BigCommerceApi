using System.Text.Json.Serialization;

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

    [Test]
    public async Task GetCustomerWithFormFieldsTestAsync()
    {
        var api = Services.GetRequiredService<BcApiCustomerGet>();
        
        const int id = 7;

        var result = await api.Include("formfields").SendAsync<BcCustomerWithFormFields>(id);
        
        DumpObject(result);

        if (result.Success)
        {
            Assert.Pass();
        }
        
        Assert.Fail();
    }
}

class BcCustomerWithFormFields : BcCustomer
{
    [JsonPropertyName("form_fields")]
    public List<BcCustomerFormField>? FormFields { get; set; }
}

class BcCustomerFormField
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("value")]
    public string? Value { get; set;  }
    
    [JsonPropertyName("customer_id")]
    public string? CustomerId { get; set; }
}