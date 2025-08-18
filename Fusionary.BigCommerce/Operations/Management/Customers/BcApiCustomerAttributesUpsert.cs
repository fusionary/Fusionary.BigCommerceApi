namespace Fusionary.BigCommerce.Operations;

public class BcApiCustomerAttributesUpsert(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<List<BcCustomerAttributeUpsert>>> SendAsync(IEnumerable<BcCustomerAttributeUpsert> attributes, CancellationToken cancellationToken = default)
    => Api.PutDataAsync<List<BcCustomerAttributeUpsert>>(BcEndpoint.CustomerAttributeValuesV3(), attributes, Filter,Options, cancellationToken);
}