namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiUser(IBcApi api) : IBcApiOperation
{
    public B2BApiUserGetAll GetAll() => new(api);
}