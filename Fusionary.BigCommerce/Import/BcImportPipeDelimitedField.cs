namespace Fusionary.BigCommerce.Import;

public record BcImportPipeDelimitedField
{
    public required string Key { get; set; }

    public required string Value { get; set; }

    public static BcImportPipeDelimitedField Parse(string optionsValue)
    {
        if (string.IsNullOrWhiteSpace(optionsValue))
        {
            return new BcImportPipeDelimitedField { Key = "", Value = "" };
        }

        var parts = optionsValue.Split('=', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
        var key   = parts[0];
        var value = parts[1];

        return new BcImportPipeDelimitedField { Key = key, Value = value };
    }

    public string ToFormattedString() => !string.IsNullOrWhiteSpace(Key) ? $"{Key}={Value}" : string.Empty;

    public override string ToString() => ToFormattedString();
}
