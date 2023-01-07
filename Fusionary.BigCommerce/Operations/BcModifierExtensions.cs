namespace Fusionary.BigCommerce.Operations;

public static class BcModifierExtensions
{
    public static string Apply(this BcModifier value, string key) =>
        value switch
        {
            BcModifier.None => $"{key}",
            BcModifier.Min => $"{key}:min",
            BcModifier.Max => $"{key}:max",
            BcModifier.In => $"{key}:in",
            BcModifier.NotIn => $"{key}:not_in",
            BcModifier.GreaterThan => $"{key}:greater",
            BcModifier.LessThan => $"{key}:less",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };

    public static string Apply(this BcRange value, string key) =>
        value switch
        {
            BcRange.None => $"{key}",
            BcRange.Min => $"{key}:min",
            BcRange.Max => $"{key}:max",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };
}