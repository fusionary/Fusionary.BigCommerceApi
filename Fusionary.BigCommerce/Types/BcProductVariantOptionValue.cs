namespace Fusionary.BigCommerce.Types;

public record BcProductVariantOptionValue
{
    public int Id { get; set; }

    /// <summary>
    /// The label of the option value.
    /// </summary>
    /// <remarks>
    /// Required - Max Length: 255
    /// </remarks>
    public string Label { get; set; } = null!;

    /// <summary>
    /// The label of the option value.
    /// </summary>
    /// <remarks>
    /// Required - Max Length: 255
    /// </remarks>
    public string OptionDisplayName { get; set; } = null!;

    public int OptionId { get; set; }
}