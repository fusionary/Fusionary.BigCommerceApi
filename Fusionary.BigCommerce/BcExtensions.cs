namespace Fusionary.BigCommerce;

public static class BcExtensions
{
    public static BcGet Get(this Bc bc) => new(bc.Api);

    public static BcCreate Create(this Bc bc) => new(bc.Api);
}