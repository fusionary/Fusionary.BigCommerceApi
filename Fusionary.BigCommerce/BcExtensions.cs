using Fusionary.BigCommerce.Operations;

namespace Fusionary.BigCommerce;

public static class BcExtensions
{
    public static BcCategoryOperations Categories(this Bc bc) => new(bc.Api);
    
    public static BcOrderOperations Orders(this Bc bc) => new(bc.Api);
    
    public static BcProductOperations Products(this Bc bc) => new(bc.Api);
}