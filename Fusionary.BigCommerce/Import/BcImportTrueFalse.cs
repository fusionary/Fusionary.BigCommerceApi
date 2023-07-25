namespace Fusionary.BigCommerce.Import;

[JsonConverter(typeof(JsonStringEnumConverter))]
public struct BcImportTrueFalse
{
    public bool Value { get; set; }

    public static implicit operator bool(BcImportTrueFalse value) => value.Value;

    public static implicit operator BcImportTrueFalse(bool value) => new() { Value = value };

    public override string ToString() => Value ? "TRUE": "FALSE";

    public static explicit operator BcImportTrueFalse(string value) => string.Equals("true", value, StringComparison.OrdinalIgnoreCase)
        ? new() { Value = true }
        : new() { Value = false };

    public static bool TryParse(string value, out BcImportTrueFalse result)
    {
        if (value is null)
        {
            result = default;
            return false;
        }

        if (value.Equals("TRUE", StringComparison.OrdinalIgnoreCase))
        {
            result = new() { Value = true };
            return true;
        }

        if (value.Equals("FALSE", StringComparison.OrdinalIgnoreCase))
        {
            result = new() { Value = false };
            return true;
        }

        result = default;
        return false;
    }
}
