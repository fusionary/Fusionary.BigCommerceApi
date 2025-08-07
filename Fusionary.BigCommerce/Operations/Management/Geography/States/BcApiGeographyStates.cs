namespace Fusionary.BigCommerce.Operations.Geography.States;

public class BcApiGeographyStates(IBcApi api) : IBcApiOperation
{
    public BcApiGeographyStatesGetAll GetAll() => new(api);
}