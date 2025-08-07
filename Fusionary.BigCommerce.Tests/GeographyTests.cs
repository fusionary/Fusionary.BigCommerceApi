using Fusionary.BigCommerce.Operations.Geography.Countries;
using Fusionary.BigCommerce.Operations.Geography.States;
using Fusionary.BigCommerce.Operations.Product_Bulk_Pricing;

namespace Fusionary.BigCommerce.Tests;

public class GeographyTests : BcTestBase
{
    [Test]
    public async Task Can_Get_Countries_Async()
    {
        var api = Services.GetRequiredService<BcApiGeographyCountryGet>();

        var results = await api.SendAsync();
        Console.WriteLine("Got {0} results", results.Data.Count);
        DumpObject(results);
        
        Assert.Pass();
    }
    
    [Test]
    public async Task Can_Get_Country_Async()
    {
        var api = Services.GetRequiredService<BcApiGeographyCountryGet>();

        var results = await api.SendAsync("226");
        
        DumpObject(results);
        
        Assert.Pass();
    }

    [Test]
    public async Task Can_Get_States_Async()
    {
        var api = Services.GetRequiredService<BcApiGeographyStatesGetAll>();

        var countryId = 226;

        var result = await api.SendAsync(countryId);
        
        DumpObject(result);

        if (result.Success && result.HasData && result.Data.Count > 0)
        {
            Assert.Pass();
        }

        Assert.Fail("No results were returned.");
    }
}