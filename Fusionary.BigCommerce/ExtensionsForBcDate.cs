namespace Fusionary.BigCommerce;

public static class BcDateExtensions
{
    public static BcDate ToBcDate(this DateTime date) => new(date);

    public static BcDate ToBcDate(this DateTimeOffset date) => new(date);

    public static BcDate ToBcDate(this DateOnly date) => new(date);

    public static BcDateTime ToBcDateTime(this DateTime date) => new(date);

    public static BcDateTime ToBcDateTime(this DateTimeOffset date) => new(date);

    public static BcDateTime ToBcDateTime(this DateOnly date) => new(date);
}