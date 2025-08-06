namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiCompany(IBcApi api) : IBcApiOperation
{
    public B2BApiCompanyGetAll GetAll() => new(api);
}