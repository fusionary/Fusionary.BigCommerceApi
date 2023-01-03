using Fusionary.BigCommerce.Operations;
using Fusionary.BigCommerce.Types;
using Fusionary.BigCommerce.Utils;

using Xunit.Abstractions;

namespace Fusionary.BigCommerce.Tests;

public class BcOrderTests: BcTestBase
{
    public BcOrderTests(ITestOutputHelper outputHelper) : base(outputHelper)
    { }

    [Fact]
    public void Can_SerializeOrder()
    {
        var order = new BcOrderPost { 
            BillingAddress = new BcBillingAddressBase
            {
                Company = "Fusionary",
                Zip = "49501"
            },
            Products = new List<BcOrderCatalogProductPost>
            {
                new()   
                {
                    ProductId = 1,
                    Quantity = 1,
                    PriceExTax = 5.00m,
                },
                new()
                {
                    ProductId = 2,
                    Quantity = 2,
                    ProductOptions = new List<BcProductOptions>()
                    {
                        new()
                        {
                            Id = 27,
                            Value = "Red"
                        }
                    }
                }
            }
        };

        var json = BcJsonUtil.Serialize(order, true);
        
        Logger.WriteLine(json);
    }
}