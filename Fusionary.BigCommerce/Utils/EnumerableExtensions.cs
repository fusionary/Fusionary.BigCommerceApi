namespace Fusionary.BigCommerce.Utils;

public static class EnumerableExtensions
{
    public static IEnumerable<T> AsEnumerable<T>(this T item)
    {
        yield return item;
    }
}