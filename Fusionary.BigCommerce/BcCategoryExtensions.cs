namespace Fusionary.BigCommerce;

public static class BcCategoryExtensions
{
    public static bool IsTopLevel(this BcCategory category)
    {
        return category.ParentId == 0;
    }
}