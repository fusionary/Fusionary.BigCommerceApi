namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApi(IBcApi api) : IBcApiOperation
{
    public B2BApiCompany Company() => new(api);

    public B2BApiPayment Payment() => new(api);
}