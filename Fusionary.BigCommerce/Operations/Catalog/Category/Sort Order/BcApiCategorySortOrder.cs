namespace Fusionary.BigCommerce.Operations;

public class BcApiCategorySortOrder(IBcApi api) : IBcApiOperation
{
    public BcApiCategorySortOrderGet Get() => new(api);

    public BcApiCategorySortOrderUpdate Update() => new(api);
}