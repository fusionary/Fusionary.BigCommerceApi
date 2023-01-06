using System.Globalization;

namespace Fusionary.BigCommerce.Types;

/// <summary>
/// Represents a BigCommerce Float, Float-As-String, Integer value
/// </summary>
[JsonConverter(typeof(BcFloatConverter))]
public struct BcFloat : IFormattable, IComparable<BcFloat>
{
    private sealed class ValueEqualityComparer : IEqualityComparer<BcFloat>
    {
        public bool Equals(BcFloat x, BcFloat y) => x.Value == y.Value;

        public int GetHashCode(BcFloat obj) => obj.Value.GetHashCode();
    }

    public static IEqualityComparer<BcFloat> ValueComparer { get; } = new ValueEqualityComparer();

    public int CompareTo(BcFloat other) => Value.CompareTo(other.Value);

    public static readonly BcFloat Zero = default;

    public BcFloat(decimal value)
    {
        Value = value;
    }

    public BcFloat(int value)
    {
        Value = Convert.ToDecimal(value);
    }

    public BcFloat(double value)
    {
        Value = Convert.ToDecimal(value);
    }

    public BcFloat(string? value)
    {
        if (!string.IsNullOrEmpty(value))
        {
            decimal.TryParse(value, out var result);
            Value = result;
        }
        else
        {
            Value = 0;
        }
    }

    public decimal Value { get; }

    public static implicit operator BcFloat(decimal value) => new(value);

    public static implicit operator BcFloat(double value) => new(value);

    public static implicit operator BcFloat(int value) => new(value);

    public static implicit operator string(BcFloat value) => value.ToString();

    public static implicit operator BcFloat(string value) => new(value);

    public string ToString(string format) => Value.ToString(format);

    public string ToMoney(int decimalDigits = 2, string currencySymbol = "$") => Value.ToString(
        "c",
        new NumberFormatInfo { CurrencySymbol = currencySymbol, CurrencyDecimalDigits = decimalDigits }
    );

    public override string ToString() => $"{Value:f}";

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}