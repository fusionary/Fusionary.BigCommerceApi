namespace Fusionary.BigCommerce.Operations.Product_Bulk_Pricing;

public class BcApiProductBulkPricing(IBcApi api) : IBcApiOperation
{
    public BcApiProductBulkPricingCreate Create() => new(api);

    public BcApiProductBulkPricingDelete Delete() => new(api);

    public BcApiProductBulkPricingGet Get() => new(api);

    public BcApiProductBulkPricingGetList GetAll() => new(api);

    public BcApiProductBulkPricingUpdate Update() => new(api);
    
}