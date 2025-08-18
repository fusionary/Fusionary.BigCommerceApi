namespace Fusionary.BigCommerce.Operations;

public class BcApiCustomerAttributes(IBcApi api) : IBcApiOperation
{
    public BcApiCustomerAttributesUpsert Upsert() => new(api);
}