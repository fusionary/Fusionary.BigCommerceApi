namespace Fusionary.BigCommerce.Types;

public static class BcCategoryExtensions
{
    public static bool IsTopLevel(this BcCategory category)
    {
        return category.ParentId == 0;
    }
}