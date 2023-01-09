namespace Fusionary.BigCommerce.Types;

public record BcModifierConfig
{
    public string? DefaultValue { get; set; }
    public bool? CheckedByDefault { get; set; }
    public string? CheckboxLabel { get; set; }
    public bool? DateLimited { get; set; }
    public string? DateLimitMode { get; set; }
    public string? DateEarliestValue { get; set; }
    public string? DateLatestValue { get; set; }
    public string? FileTypesMode { get; set; }
    public string[]? FileTypesSupported { get; set; }
    public string[]? FileTypesOther { get; set; }
    public int? FileMaxSize { get; set; }
    public bool? TextCharactersLimited { get; set; }
    public int? TextMinLength { get; set; }
    public int? TextMaxLength { get; set; }
    public bool? TextLinesLimited { get; set; }
    public int? TextMaxLines { get; set; }
    public bool? NumberLimited { get; set; }
    public string? NumberLimitMode { get; set; }
    public int? NumberLowestValue { get; set; }
    public int? NumberHighestValue { get; set; }
    public bool? NumberIntegersOnly { get; set; }
    public bool? ProductListAdjustsInventory { get; set; }
    public bool? ProductListAdjustsPricing { get; set; }
    public string? ProductListShippingCalc { get; set; }
}