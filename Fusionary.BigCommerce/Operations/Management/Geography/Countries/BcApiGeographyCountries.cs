namespace Fusionary.BigCommerce.Operations.Geography.Countries;

public class BcApiGeographyCountries(IBcApi api) : IBcApiOperation
{
    public BcApiGeographyCountryGet Get() => new(api);
}