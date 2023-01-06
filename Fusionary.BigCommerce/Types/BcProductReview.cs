namespace Fusionary.BigCommerce.Types;

public record BcProductReview
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Text { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int Rating { get; set; }

    public string Email { get; set; } = null!;

    public string Name { get; set; } = null!;

    public BcDateTime DateReviewed { get; set; } = null!;
}