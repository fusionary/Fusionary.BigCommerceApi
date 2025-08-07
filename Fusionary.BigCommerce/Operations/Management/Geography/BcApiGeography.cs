using Fusionary.BigCommerce.Operations.Geography.Countries;
using Fusionary.BigCommerce.Operations.Geography.States;

namespace Fusionary.BigCommerce.Operations.Geography;

public class BcApiGeography(IBcApi api) : IBcApiOperation
{
    public BcApiGeographyCountries Countries() => new(api);

    public BcApiGeographyStates States() => new(api);
}