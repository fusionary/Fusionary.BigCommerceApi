namespace Fusionary.BigCommerce.Types;

public record BcCategoryTreePutItem : BcCategoryTreePostItem
{
    public int CategoryId { get; set; }
}

public record BcCategoryTreeCategory : BcCategoryTreePutItem
{
}
