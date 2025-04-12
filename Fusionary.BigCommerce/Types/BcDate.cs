using System.Globalization;

namespace Fusionary.BigCommerce.Types;

/// <summary>
/// Date only values
/// </summary>
[DebuggerDisplay("{Value}")]
[JsonConverter(typeof(BcDateConverter))]
public struct BcDate : IFormattable
{
    public BcDate(DateTimeOffset value)
    {
        Value = DateOnly.FromDateTime(value.DateTime);
    }

    public BcDate(DateTime value)
    {
        Value = DateOnly.FromDateTime(value);
    }

    public BcDate(DateOnly value)
    {
        Value = value;
    }

    public BcDate(string? value)
    {
        Value = !string.IsNullOrWhiteSpace(value) &&
                DateOnly.TryParse(value, CultureInfo.CurrentCulture, out var result)
            ? result
            : default;
    }

    public DateOnly Value { get; set; }

    public bool HasValue => Value != default;

    public static implicit operator BcDate(DateTime value) => new(value);

    public static implicit operator BcDate(DateTimeOffset value) => new(value);

    public static implicit operator DateTimeOffset(BcDate value) => new(
        value.Value.Year,
        value.Value.Month,
        value.Value.Day,
        0,
        0,
        0,
        0,
        TimeSpan.Zero
    );

    public static implicit operator DateTime(BcDate value) => new(
        value.Value.Year,
        value.Value.Month,
        value.Value.Day,
        0,
        0,
        0,
        DateTimeKind.Utc
    );

    public static implicit operator DateOnly(BcDate value) => value.Value;

    public static implicit operator BcDate(DateOnly value) => new(value);

    public static implicit operator string(BcDate value) => value.ToString();

    public static implicit operator BcDate(string value) => new(value);

    public string ToString(string format) => HasValue ? Value.ToString(format) : "";

    public override string ToString() => HasValue ? Value.ToString("yyyy-MM-dd") : "";

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        HasValue ? Value.ToString(format, formatProvider) : "";
}