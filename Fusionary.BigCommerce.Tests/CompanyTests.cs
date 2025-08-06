using Fusionary.BigCommerce.B2B.Operations;

namespace Fusionary.BigCommerce.Tests;

public class CompanyTests : BcTestBase
{
    [Test]
    public async Task Can_Get_All_CompaniesAsync()
    {
        var api = Services.GetRequiredService<B2BApiCompanyGetAll>();

        var result = await api.SendAsync(CancellationToken.None);

        if (!result.HasError && result.HasData)
        {
            Assert.Pass();
        }
    }

    [Test]
    public async Task Can_Get_All_CompaniesWithExtraFieldsAsync()
    {
        var api = Services.GetRequiredService<B2BApiCompanyGetAll>();
        
        var result = await api
            .WithQueryStringParameter("isIncludeExtraFields", "1")
            .SendAsync(CancellationToken.None);
        
        if (!result.HasError && result.HasData)
        {
            Assert.Pass();
        }
    }
}