using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusionary.BigCommerce.Types
{

    public record BcCartResponseFull : IExtensionData
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("customer_id")]
        public long CustomerId { get; set; }

        [JsonPropertyName("channel_id")]
        public long ChannelId { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("currency")]
        public CurrencyClass? Currency { get; set; }

        [JsonPropertyName("tax_included")]
        public bool TaxIncluded { get; set; }

        [JsonPropertyName("base_amount")]
        public double BaseAmount { get; set; }

        [JsonPropertyName("discount_amount")]
        public long DiscountAmount { get; set; }

        [JsonPropertyName("manual_discount_amount")]
        public long ManualDiscountAmount { get; set; }

        [JsonPropertyName("cart_amount")]
        public double CartAmount { get; set; }

        [JsonPropertyName("coupons")]
        public List<object>? Coupons { get; set; }

        [JsonPropertyName("discounts")]
        public List<Discount>? Discounts { get; set; }

        [JsonPropertyName("line_items")]
        public LineItemsClass? LineItems { get; set; }

        [JsonPropertyName("created_time")]
        public DateTimeOffset CreatedTime { get; set; }

        [JsonPropertyName("updated_time")]
        public DateTimeOffset UpdatedTime { get; set; }

        [JsonPropertyName("locale")]
        public string? Locale { get; set; }

        [JsonPropertyName("version")]
        public long Version { get; set; }

        [JsonPropertyName("promotions")]
        public PromotionsClass? Promotions { get; set; }


        public partial class CurrencyClass
        {
            [JsonPropertyName("code")]
            public string? Code { get; set; }
        }

        public partial class Discount
        {
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            [JsonPropertyName("discounted_amount")]
            public long DiscountedAmount { get; set; }
        }

        public partial class LineItemsClass
        {
            [JsonPropertyName("physical_items")]
            public List<PhysicalItem>? PhysicalItems { get; set; }

            [JsonPropertyName("digital_items")]
            public List<object>? DigitalItems { get; set; }

            [JsonPropertyName("gift_certificates")]
            public List<GiftCertificate>? GiftCertificates { get; set; }

            [JsonPropertyName("custom_items")]
            public List<CustomItem>? CustomItems { get; set; }
        }

        public partial class CustomItem
        {
            [JsonPropertyName("sku")]
            public string? Sku { get; set; }

            [JsonPropertyName("name")]
            public string? Name { get; set; }

            [JsonPropertyName("quantity")]
            public long Quantity { get; set; }

            [JsonPropertyName("list_price")]
            public long ListPrice { get; set; }
        }

        public partial class GiftCertificate
        {
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            [JsonPropertyName("theme")]
            public string? Theme { get; set; }

            [JsonPropertyName("amount")]
            public long Amount { get; set; }

            [JsonPropertyName("quantity")]
            public long Quantity { get; set; }

            [JsonPropertyName("sender")]
            public RecipientSenderClass? Sender { get; set; }

            [JsonPropertyName("recipient")]
            public RecipientSenderClass? Recipient { get; set; }

            [JsonPropertyName("message")]
            public string? Message { get; set; }
        }

        public partial class RecipientSenderClass
        {
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            [JsonPropertyName("email")]
            public string? Email { get; set; }
        }

        public partial class PhysicalItem
        {
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            [JsonPropertyName("parent_id")]
            public object? ParentId { get; set; }

            [JsonPropertyName("variant_id")]
            public long VariantId { get; set; }

            [JsonPropertyName("product_id")]
            public long ProductId { get; set; }

            [JsonPropertyName("sku")]
            public string? Sku { get; set; }

            [JsonPropertyName("name")]
            public string? Name { get; set; }

            [JsonPropertyName("url")]
            public Uri? Url { get; set; }

            [JsonPropertyName("quantity")]
            public long Quantity { get; set; }

            [JsonPropertyName("taxable")]
            public bool Taxable { get; set; }

            [JsonPropertyName("image_url")]
            public Uri? ImageUrl { get; set; }

            [JsonPropertyName("discounts")]
            public List<object>? Discounts { get; set; }

            [JsonPropertyName("coupons")]
            public List<object>? Coupons { get; set; }

            [JsonPropertyName("discount_amount")]
            public long DiscountAmount { get; set; }

            [JsonPropertyName("coupon_amount")]
            public long CouponAmount { get; set; }

            [JsonPropertyName("original_price")]
            public double OriginalPrice { get; set; }

            [JsonPropertyName("list_price")]
            public double ListPrice { get; set; }

            [JsonPropertyName("sale_price")]
            public double SalePrice { get; set; }

            [JsonPropertyName("extended_list_price")]
            public double ExtendedListPrice { get; set; }

            [JsonPropertyName("extended_sale_price")]
            public double ExtendedSalePrice { get; set; }

            [JsonPropertyName("is_require_shipping")]
            public bool IsRequireShipping { get; set; }

            [JsonPropertyName("is_mutable")]
            public bool IsMutable { get; set; }

            [JsonPropertyName("options")]
            public List<Option>? Options { get; set; }
        }

        public partial class Option
        {
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            [JsonPropertyName("nameId")]
            public long NameId { get; set; }

            [JsonPropertyName("value")]
            public string? Value { get; set; }

            [JsonPropertyName("valueId")]
            public object? ValueId { get; set; }
        }

        public partial class PromotionsClass
        {
            [JsonPropertyName("banners")]
            public List<object>? Banners { get; set; }
        }


         public IDictionary<string, JsonElement>? ExtensionData { get; init; }
    }
}
