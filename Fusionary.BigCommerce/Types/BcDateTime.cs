namespace Fusionary.BigCommerce.Types;

/// <summary>
/// Represents a BigCommerce RFC2822 or ISO8601 DateTime value
/// </summary>
[DebuggerDisplay("{Value}")]
[JsonConverter(typeof(BcDateTimeConverter))]
public struct BcDateTime : IFormattable
{
    public BcDateTime(DateTimeOffset value)
    {
        Value = value;
    }

    public BcDateTime(DateTime value)
    {
        Value = new DateTimeOffset(value);
    }

    public BcDateTime(DateOnly value)
    {
        Value = new DateTimeOffset(new DateTime(value.Year, value.Month, value.Day));
    }

    public BcDateTime(string? value)
    {
        Value = !string.IsNullOrWhiteSpace(value) && DateTimeOffset.TryParse(value, out var result)
            ? result
            : default;
    }

    public DateTimeOffset Value { get; set; }

    public bool HasValue => Value != default;

    public static implicit operator BcDateTime(DateTime value) => new(value);

    public static implicit operator BcDateTime(DateTimeOffset value) => new(value);

    public static implicit operator DateTimeOffset(BcDateTime value) => value.Value;

    public static implicit operator DateTime(BcDateTime value) => value.Value.DateTime;

    public static implicit operator DateOnly(BcDateTime value) => DateOnly.FromDateTime(value.Value.DateTime);

    public static implicit operator BcDateTime(DateOnly value) => new(value);

    public static implicit operator string(BcDateTime value) => value.ToString();

    public static implicit operator BcDateTime(string value) => new(value);

    public string ToIso8601() => HasValue ? Value.ToString("o") : "";

    public string ToRfc2822() => HasValue ? Value.ToString("ddd, dd MMM yyyy HH:mm:ss zzzz").Remove(29, 1) : "";

    public string ToString(string format) => HasValue ? Value.ToString(format) : "";

    public override string ToString() => ToIso8601();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}