namespace Fusionary.BigCommerce.Types;

/// <summary>
/// Represents a BigCommerce Float, Float-As-String, Integer value
/// </summary>
[JsonConverter(typeof(BcFloatConverter))]
public struct BcFloat
{
    public static readonly BcFloat Zero = new(0);

    public BcFloat(decimal value)
    {
        Value = value;
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

    public static implicit operator BcFloat(decimal value) => new BcFloat(value);

    public static implicit operator BcFloat(double value) => new BcFloat(Convert.ToDecimal(value));

    public static implicit operator BcFloat(int value) => new BcFloat(Convert.ToDecimal(value));

    public static implicit operator string(BcFloat value) => value.ToString();

    public static implicit operator BcFloat(string value) => new BcFloat(value);

    public string ToString(string format) => Value.ToString(format);

    public override string ToString() => $"{Value:f}";
}