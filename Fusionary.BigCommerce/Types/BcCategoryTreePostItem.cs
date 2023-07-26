namespace Fusionary.BigCommerce.Types;

public record BcCategoryTreePostItem : BcCategoryPost
{
    public int TreeId { get; set; }
    
    public BcDefaultProductSort? DefaultProductSort { get; set; }
}