namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForBcModifier
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
}