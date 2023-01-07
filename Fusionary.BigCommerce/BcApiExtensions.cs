namespace Fusionary.BigCommerce;

public static class BcApiExtensions
{
    public static BcBrandOperations Brands(this IBcApi bc) => new(bc);

    public static BcCategoryOperations Categories(this IBcApi bc) => new(bc);

    public static BcOrderOperations Orders(this IBcApi bc) => new(bc);

    public static BcProductOperations Products(this IBcApi bc) => new(bc);

    public static BcStorefrontOperations Storefront(this IBcApi bc) => new(bc);
}