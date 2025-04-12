namespace Fusionary.BigCommerce.Operations;

public static class ExtensionsForBcRange
{
    public static string Apply(this BcRange value, string key) =>
        value switch
        {
            BcRange.None => $"{key}",
            BcRange.Min => $"{key}:min",
            BcRange.Max => $"{key}:max",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };
}