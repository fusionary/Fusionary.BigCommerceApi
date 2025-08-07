using System.Diagnostics.CodeAnalysis;

namespace Fusionary.BigCommerce.Operations;

[SuppressMessage("Minor Code Smell", "S3400:Methods should not return constants")]
public static class BcEndpoint
{
    public static string BrandImageV3(BcId brandId) => $"v3/catalog/brands/{brandId}/images";

    public static string BrandMetafieldsV3() => $"v3/catalog/brands/metafields";
    
    public static string BrandMetafieldsV3(BcId brandId) => $"v3/catalog/brands/{brandId}/metafields";

    public static string BrandMetafieldsV3(BcId brandId, BcId metafieldId) =>
        $"v3/catalog/brands/{brandId}/metafields/{metafieldId}";

    public static string BrandsV3() => "v3/catalog/brands";

    public static string BrandsV3(BcId brandId) => $"v3/catalog/brands/{brandId}";

    public static string CategoryImagesV3(BcId categoryId) => $"v3/catalog/categories/{categoryId}/image";

    public static string CategoryMetafieldsV3(BcId categoryId) => $"v3/catalog/categories/{categoryId}/metafields";

    public static string CategoryMetafieldsV3(BcId categoryId, BcId metafieldId) =>
        $"v3/catalog/categories/{categoryId}/metafields/{metafieldId}";

    public static string CategorySortOrderV3(BcId categoryId) =>
        $"v3/catalog/categories/{categoryId}/products/sort-order";

    public static string CategoryTreeCategoriesV3() => "v3/catalog/trees/categories";

    public static string CategoryTreeCategoriesV3(BcId treeId) => $"v3/catalog/trees/{treeId}/categories";

    public static string CategoryTreesV3() => "v3/catalog/trees";

    public static string CategoryV3() => "v3/catalog/categories";

    public static string CategoryV3(BcId categoryId) => $"v3/catalog/categories/{categoryId}";

    public static string ChannelsV3() => "v3/channels";

    public static string ChannelsV3(BcId channelId) => $"v3/channels/{channelId}";

    public static string CustomersGroupsV2() => "v2/customer_groups";

    public static string CustomersGroupsV2(BcId groupId) => $"v2/customer_groups/{groupId}";

    public static string CustomerAttributesV3() => "v3/customers/attributes";
    
    public static string CustomersV3() => "v3/customers";

    public static string CustomersV3(BcId customerId) => $"v3/catalog/customers/{customerId}";

    public static string OrderMetafieldsV3(BcId orderId) => $"v3/orders/{orderId}/metafields";

    public static string OrderMetafieldsV3(BcId orderId, BcId metafieldId) =>
        $"v3/orders/{orderId}/metafields/{metafieldId}";

    public static string OrderProductsV2(BcId orderId) => $"v2/orders/{orderId}/products";

    public static string OrderProductsV2(BcId orderId, BcId productId) =>
        $"v2/orders/{orderId}/products/{productId}";

    public static string OrderShipmentsV2(BcId orderId) => $"v2/orders/{orderId}/shipments";

    public static string OrderShippingV2(BcId orderId) => $"v2/orders/{orderId}/shipping_addresses";

    public static string OrdersV2(BcId orderId) => $"v2/orders/{orderId}";

    public static string OrdersV2() => "v2/orders";

    public static string PriceListAssignmentsV3() => "v3/pricelists/assignments";

    public static string PriceListAssignmentsV3(BcId priceListId) => $"v3/pricelists/{priceListId}/assignments";

    public static string PriceListRecordsV3(BcId priceListId) => $"v3/pricelists/{priceListId}/records";

    public static string PriceListRecordsV3(BcId priceListId, BcId recordId) =>
        $"v3/pricelists/{priceListId}/records/{recordId}";

    public static string PriceListsV3() => "v3/pricelists";

    public static string PriceListsV3(BcId priceListId) => $"v3/pricelists/{priceListId}";

    public static string PricingProductsV3() => "v3/pricing/products";

    public static string ProductBulkPricingRulesV3(BcId productId) =>
        $"v3/catalog/products/{productId}/bulk-pricing-rules";

    public static string ProductBulkPricingRulesV3(BcId productId, BcId bulkPricingRuleId) =>
        $"v3/catalog/products/{productId}/bulk-pricing-rules/{bulkPricingRuleId}";
    
    public static string ProductCategoryAssignmentsV3() => "v3/catalog/products/category-assignments";

    public static string ProductChannelAssignmentsV3() => "v3/catalog/products/channel-assignments";

    public static string ProductComplexRulesV3(BcId productId) => $"v3/catalog/products/{productId}/complex-rules";

    public static string ProductCustomFieldsV3(BcId productId) => $"v3/catalog/products/{productId}/custom-fields";
    

    public static string ProductCustomFieldsV3(BcId productId, BcId customFieldId) =>
        $"v3/catalog/products/{productId}/custom-fields/{customFieldId}";

    public static string ProductImagesV3(BcId productId) => $"v3/catalog/products/{productId}/images";

    public static string ProductImagesV3(BcId productId, BcId imageId) =>
        $"v3/catalog/products/{productId}/images/{imageId}";

    public static string ProductMetafieldsV3(BcId productId) => $"v3/catalog/products/{productId}/metafields";

    public static string ProductMetafieldsV3(BcId productId, BcId customFieldId) =>
        $"v3/catalog/products/{productId}/metafields/{customFieldId}";

    public static string ProductModifierImageV3(BcId productId, BcId modifierId, BcId valueId) =>
        $"v3/catalog/products/{productId}/modifiers/{modifierId}/values/{valueId}/image";

    public static string ProductModifiersV3(BcId productId) => $"v3/catalog/products/{productId}/modifiers";

    public static string ProductModifiersV3(BcId productId, BcId modifierId) =>
        $"v3/catalog/products/{productId}/modifiers/{modifierId}";

    public static string ProductModifierValuesV3(BcId productId, BcId modifierId) =>
        $"v3/catalog/products/{productId}/modifiers/{modifierId}/values";

    public static string ProductModifierValuesV3(BcId productId, BcId modifierId, BcId valueId) =>
        $"v3/catalog/products/{productId}/modifiers/{modifierId}/values/{valueId}";

    public static string ProductOptionsV3(BcId productId) => $"v3/catalog/products/{productId}/options";

    public static string ProductOptionsV3(BcId productId, BcId optionId) =>
        $"v3/catalog/products/{productId}/options/{optionId}";

    public static string ProductReviewsV3(BcId productId) =>
        $"v3/catalog/products/{productId}/reviews";

    public static string ProductReviewsV3(BcId productId, BcId reviewId) =>
        $"v3/catalog/products/{productId}/reviews/{reviewId}";

    public static string ProductSkusV3(BcId productId) => $"v3/catalog/products/{productId}/skus";

    public static string ProductsV3(BcId productId) => $"v3/catalog/products/{productId}";

    public static string ProductsV3() => "v3/catalog/products";

    public static string ProductVariantImageV3(BcId productId, BcId variantId) =>
        $"v3/catalog/products/{productId}/variants/{variantId}/image";

    public static string ProductVariantMetafieldsV3(BcId productId, BcId variantId) =>
        $"v3/catalog/products/{productId}/variants/{variantId}/metafields";

    public static string ProductVariantMetafieldsV3(BcId productId, BcId variantId, BcId metafieldId) =>
        $"v3/catalog/products/{productId}/variants/{variantId}/metafields/{metafieldId}";

    public static string ProductVariantsV3() => "v3/catalog/variants";

    public static string ProductVariantsV3(BcId productId) => $"v3/catalog/products/{productId}/variants";

    public static string ProductVariantsV3(BcId productId, BcId variantId) =>
        $"v3/catalog/products/{productId}/variants/{variantId}";

    public static string ProductVideosV3(BcId productId) => $"v3/catalog/products/{productId}/videos";

    public static string ProductVideosV3(BcId productId, BcId videoId) =>
        $"v3/catalog/products/{productId}/videos/{videoId}";

    public static string StorefrontTokensV3() => "v3/storefront/api-token";

    public static string SummaryV3() => "v3/catalog/summary";

    public static string WebhooksV3() => "v3/hooks";

    public static string WebhooksV3(BcId webhookId) => $"v3/hooks/{webhookId}";

    public static string Countries() => $"v2/countries";
    
    public static string Countries(string id) => $"v2/countries/{id}";

    public static string States(int countryId) => $"v2/countries/{countryId}/states";
}