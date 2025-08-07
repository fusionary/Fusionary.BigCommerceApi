namespace Fusionary.BigCommerce.Operations.Geography.Countries;

public class BcApiGeographyCountryGet(IBcApi api) : BcRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultData<BcCountry>> SendAsync(string id, CancellationToken cancellationToken = default) 
        => SendAsync<BcCountry>(id, cancellationToken);

    public Task<BcResultData<T>> SendAsync<T>(string id, CancellationToken cancellationToken = default)
        => Api.GetDataAsync<T>(BcEndpoint.Countries(id), Filter, Options, cancellationToken);

    
    public Task<BcResultData<List<BcCountry>>> SendAsync(CancellationToken cancellationToken = default)
    => SendAsync<BcCountry>(cancellationToken);
    
    public Task<BcResultData<List<T>>> SendAsync<T>(CancellationToken cancellationToken = default)
    {
        Filter.Add("limit", 250);
        return Api.GetDataAsync<List<T>>(BcEndpoint.Countries(), Filter, Options, cancellationToken);
    }
}