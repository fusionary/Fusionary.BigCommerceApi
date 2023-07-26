namespace Fusionary.BigCommerce.Import;

[JsonConverter(typeof(JsonStringEnumConverter))]
public struct BcImportTrueFalse
{
    public bool Value { get; set; }

    public static BcImportTrueFalse True => new() { Value = true };

    public static BcImportTrueFalse False => new() { Value = false };

    public static implicit operator bool(BcImportTrueFalse value) => value.Value;

    public static implicit operator BcImportTrueFalse(bool value) => new() { Value = value };

    public override string ToString() => Value ? "TRUE": "FALSE";

    public static explicit operator BcImportTrueFalse(string value) => string.Equals("TRUE", value, StringComparison.OrdinalIgnoreCase)
        ? True
        : False;

    public static bool TryParse(string value, out BcImportTrueFalse result)
    {
        if (value.Equals("TRUE", StringComparison.OrdinalIgnoreCase))
        {
            result = True;
            return true;
        }

        if (value.Equals("FALSE", StringComparison.OrdinalIgnoreCase))
        {
            result = False;
            return true;
        }

        result = default;
        return false;
    }
}
