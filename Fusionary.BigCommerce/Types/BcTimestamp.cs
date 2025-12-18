namespace Fusionary.BigCommerce.Types;

/// <summary>
/// Represents a Unix timestamp (seconds since epoch) for BigCommerce APIs that use integer timestamps.
/// </summary>
[DebuggerDisplay("{Value}")]
[JsonConverter(typeof(BcTimestampConverter))]
public readonly struct BcTimestamp : IFormattable
{
    public BcTimestamp(int value)
    {
        Value = value;
    }

    public BcTimestamp(long value)
    {
        Value = (int)value;
    }

    public BcTimestamp(DateTime value)
    {
        Value = (int)new DateTimeOffset(value).ToUnixTimeSeconds();
    }

    public BcTimestamp(DateTimeOffset value)
    {
        Value = (int)value.ToUnixTimeSeconds();
    }

    public BcTimestamp(DateOnly value)
    {
        Value = (int)new DateTimeOffset(value.ToDateTime(TimeOnly.MinValue), TimeSpan.Zero).ToUnixTimeSeconds();
    }

    public int Value { get; init; }

    public bool HasValue => Value != 0;

    public DateTimeOffset ToDateTimeOffset() => DateTimeOffset.FromUnixTimeSeconds(Value);

    public DateTime ToDateTime() => ToDateTimeOffset().UtcDateTime;

    public DateOnly ToDateOnly() => DateOnly.FromDateTime(ToDateTime());

    public static implicit operator int(BcTimestamp timestamp) => timestamp.Value;

    public static implicit operator BcTimestamp(int value) => new(value);

    public static implicit operator BcTimestamp(long value) => new(value);

    public static implicit operator BcTimestamp(DateTime value) => new(value);

    public static implicit operator BcTimestamp(DateTimeOffset value) => new(value);

    public static implicit operator BcTimestamp(DateOnly value) => new(value);

    public static implicit operator DateTimeOffset(BcTimestamp timestamp) => timestamp.ToDateTimeOffset();

    public static implicit operator DateTime(BcTimestamp timestamp) => timestamp.ToDateTime();

    public override string ToString() => HasValue ? ToDateTimeOffset().ToString("o") : "";

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        HasValue ? ToDateTimeOffset().ToString(format, formatProvider) : "";
}
