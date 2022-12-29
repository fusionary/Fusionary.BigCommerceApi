namespace Fusionary.BigCommerce;

public static class BcEndpoint
{
    public static string CategoriesV3() => "v3/catalog/categories";

    public static string ProductsV3(object productId) => $"v3/catalog/products/{productId}";

    public static string ProductsV3() => "v3/catalog/products";

    public static string OrderV2(object orderId) => $"v2/orders/{orderId}";

    public static string OrdersV2() => "v2/orders";
}