namespace Fusionary.BigCommerce;

public static class BcExtensions
{
    public static BcCategoryManagementApi Categories(this Bc bc) => new(bc.Api);
    
    public static BcOrderManagementApi Orders(this Bc bc) => new(bc.Api);
    
    public static BcProductManagementApi Products(this Bc bc) => new(bc.Api);
}