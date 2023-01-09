namespace Fusionary.BigCommerce.Types;

public record BcProductImagePut : BcProductImagePost
{
    /// <summary>
    /// The unique numeric ID of the image; increments sequentially.
    /// </summary>
    public int Id { get; set; }
}