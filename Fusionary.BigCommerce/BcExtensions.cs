namespace Fusionary.BigCommerce;

public static class BcExtensions
{
    public static BcCategoryOperations Categories(this Bc bc) => new(bc.Api);

    public static bool HasErrorDetails(this BcErrorBase error, out Dictionary<string, string> errorDetails)
    {
        if (error is not BcErrorDetails details || details.Errors.Count <= 0)
        {
            errorDetails = null!;
            return false;
        }

        errorDetails = details.Errors;
        return true;
    }

    public static BcOrderOperations Orders(this Bc bc) => new(bc.Api);

    public static BcProductOperations Products(this Bc bc) => new(bc.Api);

    public static BcStorefrontOperations Storefront(this Bc bc) => new(bc.Api);
}