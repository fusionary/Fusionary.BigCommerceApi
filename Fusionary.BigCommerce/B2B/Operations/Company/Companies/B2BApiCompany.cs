namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiCompany(IBcApi api) : IBcApiOperation
{
    public B2BApiCompanyGet Get() => new(api);
    
    public B2BApiCompanyGetAll GetAll() => new(api);
    
    public B2BApiCompanyCreate Create() => new(api);
    
    public B2BApiCompanyUpdate Update() => new(api);
}