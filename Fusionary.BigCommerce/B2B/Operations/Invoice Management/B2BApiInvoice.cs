namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiInvoice(IBcApi api) : IBcApiOperation
{
    public B2BApiInvoiceGet Get() => new(api);

    public B2BApiInvoiceCreate Create() => new(api);
    
    public B2BApiInvoiceUpdate Update() => new(api);
}