namespace Fusionary.BigCommerce.Operations.CustomerAttributes;

public class BcApiCustomerAttributeDefinitionGetAll : BcRequestBuilder,
    IBcApiOperation,
    IBcPageableFilter
{
    public  BcApiCustomerAttributeDefinitionGetAll(IBcApi api) : base(api) { }
    
    public async Task<BcResultPaged<BcCustomerAttributeDefinition>> SendAsync(CancellationToken cancellationToken = default)
    => await SendAsync<BcCustomerAttributeDefinition>(cancellationToken);
    
    public async Task<BcResultPaged<T>> SendAsync<T>(
        CancellationToken cancellationToken = default
    ) => await Api.GetPagedAsync<T>(
        BcEndpoint.CustomerAttributesV3(),
        Filter,
        Options,
        cancellationToken
    );
}