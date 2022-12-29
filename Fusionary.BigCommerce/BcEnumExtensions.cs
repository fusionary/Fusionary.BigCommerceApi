namespace Fusionary.BigCommerce;

public static class BcEnumExtensions
{
    public static string ToValue(this BcDirection value) =>
        value switch
        {
            BcDirection.Asc => "asc",
            BcDirection.Desc => "desc",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };

    public static string ToValue(this BcAvailability value) =>
        value switch
        {
            BcAvailability.Available => "available",
            BcAvailability.Disabled => "disabled",
            BcAvailability.Preorder => "preorder",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };

    public static string ToValue(this BcCondition value) =>
        value switch
        {
            BcCondition.New => "new",
            BcCondition.Used => "used",
            BcCondition.Refurbished => "refurbished",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };

    public static string ToValue(this BcOrderSort value) =>
        value switch
        {
            BcOrderSort.Id => "id",
            BcOrderSort.IdDesc => "id:desc",
            BcOrderSort.CustomerId => "customer_id",
            BcOrderSort.CustomerIdDesc => "customer_id:desc",
            BcOrderSort.DateCreated => "date_created",
            BcOrderSort.DateCreatedDesc => "date_created:desc",
            BcOrderSort.DateModified => "date_modified",
            BcOrderSort.DateModifiedDesc => "date_modified:desc",
            BcOrderSort.StatusId => "status_id",
            BcOrderSort.StatusIdDesc => "status_id:desc",
            BcOrderSort.ChannelId => "channel_id",
            BcOrderSort.ChannelIdDesc => "channel_id:desc",
            BcOrderSort.ExternalId => "external_id",
            BcOrderSort.ExternalIdDesc => "external_id:desc",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };

    public static string ToValue(this BcProductInclude value) =>
        value switch
        {
            BcProductInclude.Variants => "variants",
            BcProductInclude.Images => "images",
            BcProductInclude.CustomFields => "custom_fields",
            BcProductInclude.BulkPricingRules => "bulk_pricing_rules",
            BcProductInclude.PrimaryImage => "primary_image",
            BcProductInclude.Modifiers => "modifiers",
            BcProductInclude.Options => "options",
            BcProductInclude.Videos => "videos",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };

    public static string ToValue(this BcProductSort value) =>
        value switch
        {
            BcProductSort.Id => "id",
            BcProductSort.Name => "name",
            BcProductSort.Sku => "sku",
            BcProductSort.DateModified => "date_modified",
            BcProductSort.DateLastImported => "date_last_imported",
            BcProductSort.InventoryLevel => "inventory_level",
            BcProductSort.IsVisible => "is_visible",
            BcProductSort.TotalSold => "total_sold",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };

    public static string ToValue(this BcProductType value) =>
        value switch
        {
            BcProductType.Physical => "physical",
            BcProductType.Digital => "digital",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };

    public static string ToValue(this BcBit value) =>
        value switch
        {
            BcBit.On => "1",
            BcBit.Off => "0",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };
}