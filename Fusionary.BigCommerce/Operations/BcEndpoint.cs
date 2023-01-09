namespace Fusionary.BigCommerce.Operations;

public static class BcEndpoint
{
    public static string BrandImagesV3(object brandId) => $"v3/catalog/brands/{brandId}/images";

    public static string BrandMetafieldsV3(object brandId) => $"v3/catalog/brands/{brandId}/metafields";

    public static string BrandMetafieldsV3(object brandId, object metafieldId) =>
        $"v3/catalog/brands/{brandId}/metafields/{metafieldId}";

    public static string BrandsV3() => "v3/catalog/brands";

    public static string BrandsV3(object brandId) => $"v3/catalog/brands/{brandId}";

    public static string CategoriesBatchV3() => "v3/catalog/trees/categories";

    public static string CategoriesV3() => "v3/catalog/categories";

    public static string CategoriesV3(object categoryId) => $"v3/catalog/categories/{categoryId}";

    public static string CategoryMetafieldsV3(object categoryId) => $"v3/catalog/categories/{categoryId}/metafields";

    public static string CategoryMetafieldsV3(object categoryId, object metafieldId) =>
        $"v3/catalog/categories/{categoryId}/metafields/{metafieldId}";

    public static string CategoryProductSortOrderV3(object categoryId) =>
        $"v3/catalog/categories/{categoryId}/products/sort-order";

    public static string OrderMetafieldsV3(object orderId) => $"v3/orders/{orderId}/metafields";

    public static string OrderMetafieldsV3(object orderId, object metafieldId) =>
        $"v3/orders/{orderId}/metafields/{metafieldId}";

    public static string OrderProductsV2(object orderId) => $"v3/orders/{orderId}/products";

    public static string OrderProductsV2(object orderId, object productId) =>
        $"v3/orders/{orderId}/products/{productId}";

    public static string OrdersV2(object orderId) => $"v2/orders/{orderId}";

    public static string OrdersV2() => "v2/orders";

    public static string ProductBulkPricingRulesV3(object productId) =>
        $"v3/catalog/products/{productId}/bulk-pricing-rules";

    public static string ProductChannelAssignmentsV3() => "v3/catalog/products/channel-assignments";

    public static string ProductCustomFieldsV3(object productId) => $"v3/catalog/products/{productId}/custom-fields";

    public static string ProductCustomFieldsV3(object productId, object customFieldId) =>
        $"v3/catalog/products/{productId}/custom-fields/{customFieldId}";

    public static string ProductImagesV3(object productId) => $"v3/catalog/products/{productId}/images";

    public static string ProductImagesV3(object productId, object imageId) =>
        $"v3/catalog/products/{productId}/images/{imageId}";

    public static string ProductMetafieldsV3(object productId) => $"v3/catalog/products/{productId}/metafields";

    public static string ProductMetafieldsV3(object productId, object customFieldId) =>
        $"v3/catalog/products/{productId}/metafields/{customFieldId}";

    public static string ProductModifiersV3(object productId) => $"v3/catalog/products/{productId}/modifiers";

    public static string ProductModifiersV3(object productId, object modifierId) =>
        $"v3/catalog/products/{productId}/modifiers/{modifierId}";

    public static string ProductOptionsV3(object productId) => $"v3/catalog/products/{productId}/options";

    public static string ProductOptionsV3(object productId, object optionId) =>
        $"v3/catalog/products/{productId}/options/{optionId}";

    public static string ProductSkusV3(object productId) => $"v3/catalog/products/{productId}/skus";

    public static string ProductsV3(object productId) => $"v3/catalog/products/{productId}";

    public static string ProductsV3() => "v3/catalog/products";

    public static string ProductVariantsV3(object productId) => $"v3/catalog/products/{productId}/variants";

    public static string ProductVideosV3(object productId) => $"v3/catalog/products/{productId}/videos";

    public static string StorefrontTokensV3() => "v3/storefront/api-token";

    public static string SummaryV3() => "v3/catalog/summary";

    public static string VariantsV3() => "v3/catalog/variants";
}