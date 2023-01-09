namespace Fusionary.BigCommerce.Types;

public record BcProductModifierPost
{
    public int ProductId { get; set; }
    public string Name { get; set; } = null!;
    public string DisplayName { get; set; } = null!;
    public BcProductModifierType Type { get; set; }
    public bool Required { get; set; }
    public BcModifierConfig? Config { get; set; }
    public List<BcModifierOptionValue>? OptionValues { get; set; }
}