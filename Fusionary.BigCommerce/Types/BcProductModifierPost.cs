namespace Fusionary.BigCommerce.Types;

public record BcProductModifierPost : BcExtensionData
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public BcProductModifierType Type { get; set; }

    public bool Required { get; set; }

    public BcOptionConfig? Config { get; set; }

    public List<BcModifierOptionValue>? OptionValues { get; set; }
}