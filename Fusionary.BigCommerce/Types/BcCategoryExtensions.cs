namespace Fusionary.BigCommerce.Types;

public static class BcCategoryExtensions
{
    public static bool IsTopLevel(this BcCategory category) => category.ParentId == 0;
}