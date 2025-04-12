namespace Fusionary.BigCommerce.Operations;

public class BcApiCategoryImage(IBcApi api) : IBcApiOperation
{
    public BcApiCategoryImageCreate Create() => new(api);

    public BcApiCategoryImageDelete Delete() => new(api);
}