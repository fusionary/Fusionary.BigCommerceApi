namespace Fusionary.BigCommerce.Operations.Geography.States;

public class BcApiGeographyStatesGetAll(IBcApi api) : BcRequestBuilder(api), IBcApiOperation, IBcPageableFilter
{
    public Task<BcResultData<List<BcCountryState>>> SendAsync(int countryId, CancellationToken cancellationToken = default)
        => SendAsync<BcCountryState>(countryId, cancellationToken);

    public Task<BcResultData<List<T>>> SendAsync<T>(int countryId, CancellationToken cancellationToken = default)
    {
        Filter.Add("limit", 200);
        return Api.GetDataAsync<List<T>>(BcEndpoint.States(countryId), Filter, Options, cancellationToken);
    }    
}