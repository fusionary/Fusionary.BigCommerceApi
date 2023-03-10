namespace Fusionary.BigCommerce.Operations;

public static class BcEndpoint
{
    public static string BrandImagesV3(BcId brandId) => $"v3/catalog/brands/{brandId}/images";

    public static string BrandImagesV3(BcId brandId, BcId imageId) => $"v3/catalog/brands/{brandId}/images/{imageId}";

    public static string BrandMetafieldsV3(BcId brandId) => $"v3/catalog/brands/{brandId}/metafields";

    public static string BrandMetafieldsV3(BcId brandId, BcId metafieldId) =>
        $"v3/catalog/brands/{brandId}/metafields/{metafieldId}";

    public static string BrandsV3() => "v3/catalog/brands";

    public static string BrandsV3(BcId brandId) => $"v3/catalog/brands/{brandId}";

    public static string CategoriesBatchV3() => "v3/catalog/trees/categories";

    public static string CategoryMetafieldsV3(BcId categoryId) => $"v3/catalog/categories/{categoryId}/metafields";

    public static string CategoryMetafieldsV3(BcId categoryId, BcId metafieldId) =>
        $"v3/catalog/categories/{categoryId}/metafields/{metafieldId}";

    public static string CategoryProductSortOrderV3(BcId categoryId) =>
        $"v3/catalog/categories/{categoryId}/products/sort-order";

    public static string CategoryV3() => "v3/catalog/categories";

    public static string CategoryV3(BcId categoryId) => $"v3/catalog/categories/{categoryId}";

    public static string OrderMetafieldsV3(BcId orderId) => $"v3/orders/{orderId}/metafields";

    public static string OrderMetafieldsV3(BcId orderId, BcId metafieldId) =>
        $"v3/orders/{orderId}/metafields/{metafieldId}";

    public static string OrderProductsV2(BcId orderId) => $"v2/orders/{orderId}/products";

    public static string OrderProductsV2(BcId orderId, BcId productId) =>
        $"v2/orders/{orderId}/products/{productId}";

    public static string OrdersV2(BcId orderId) => $"v2/orders/{orderId}";

    public static string OrdersV2() => "v2/orders";

    public static string ProductBulkPricingRulesV3(BcId productId) =>
        $"v3/catalog/products/{productId}/bulk-pricing-rules";

    public static string ProductChannelAssignmentsV3() => "v3/catalog/products/channel-assignments";

    public static string ProductCustomFieldsV3(BcId productId) => $"v3/catalog/products/{productId}/custom-fields";

    public static string ProductCustomFieldsV3(BcId productId, BcId customFieldId) =>
        $"v3/catalog/products/{productId}/custom-fields/{customFieldId}";

    public static string ProductImagesV3(BcId productId) => $"v3/catalog/products/{productId}/images";

    public static string ProductImagesV3(BcId productId, BcId imageId) =>
        $"v3/catalog/products/{productId}/images/{imageId}";

    public static string ProductMetafieldsV3(BcId productId) => $"v3/catalog/products/{productId}/metafields";

    public static string ProductMetafieldsV3(BcId productId, BcId customFieldId) =>
        $"v3/catalog/products/{productId}/metafields/{customFieldId}";

    public static string ProductModifiersV3(BcId productId) => $"v3/catalog/products/{productId}/modifiers";

    public static string ProductModifiersV3(BcId productId, BcId modifierId) =>
        $"v3/catalog/products/{productId}/modifiers/{modifierId}";

    public static string ProductOptionsV3(BcId productId) => $"v3/catalog/products/{productId}/options";

    public static string ProductOptionsV3(BcId productId, BcId optionId) =>
        $"v3/catalog/products/{productId}/options/{optionId}";

    public static string ProductSkusV3(BcId productId) => $"v3/catalog/products/{productId}/skus";

    public static string ProductsV3(BcId productId) => $"v3/catalog/products/{productId}";

    public static string ProductsV3() => "v3/catalog/products";

    public static string ProductVariantsV3(BcId productId) => $"v3/catalog/products/{productId}/variants";

    public static string ProductVariantsV3(BcId productId, BcId variantId) =>
        $"v3/catalog/products/{productId}/variants/{variantId}";

    public static string ProductVideosV3(BcId productId) => $"v3/catalog/products/{productId}/videos";

    public static string StorefrontTokensV3() => "v3/storefront/api-token";

    public static string SummaryV3() => "v3/catalog/summary";

    public static string VariantsV3() => "v3/catalog/variants";
}