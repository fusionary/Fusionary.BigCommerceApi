namespace Fusionary.BigCommerce.Types;

/// <summary>
/// A flexible input type for ID values that can be either a string or an integer.
/// </summary>
[DebuggerDisplay("{Value}")]
[JsonConverter(typeof(BcIdConverter))]
public readonly struct BcId : IFormattable
{
    public BcId(long value)
    {
        Value = Convert.ToInt32(value);
    }

    public BcId(short value)
    {
        Value = Convert.ToInt32(value);
    }

    public BcId(int value)
    {
        Value = value;
    }

    public BcId(string? value)
    {
        if (!string.IsNullOrEmpty(value))
        {
            int.TryParse(value, out var result);
            Value = result;
        }
        else
        {
            Value = 0;
        }
    }

    public int Value { get; init; }

    public static implicit operator int(BcId id) => id.Value;

    public static implicit operator BcId(int id) => new(id);

    public static implicit operator BcId(short id) => new(id);

    public static implicit operator BcId(long id) => new(id);

    public static implicit operator string(BcId id) => id.Value.ToString();

    public static implicit operator BcId(string? id) => new(id);

    public readonly string ToString(string? format, IFormatProvider? formatProvider) =>
        Value.ToString(format, formatProvider);
}