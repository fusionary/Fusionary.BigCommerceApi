namespace Fusionary.BigCommerce.Operations;

public class BcApiBrandImage(IBcApi api) : IBcApiOperation
{
    public BcApiBrandImageCreate Create() => new(api);

    public BcApiBrandImageDelete Delete() => new(api);
}