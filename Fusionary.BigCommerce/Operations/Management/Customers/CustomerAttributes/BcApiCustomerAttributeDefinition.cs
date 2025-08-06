namespace Fusionary.BigCommerce.Operations.CustomerAttributes;

public class BcApiCustomerAttributeDefinition(IBcApi api) : IBcApiOperation
{
    public BcApiCustomerAttributeDefinitionGetAll GetAll() => new(api);
}