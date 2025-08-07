namespace Fusionary.BigCommerce.Types;

public class BcCustomer
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("company")]
    public string? Company { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("registration_ip_address")]
    public string? RegistrationIpAddress { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("tax_exempt_category")]
    public string? TaxExemptCategory { get; set; }

    [JsonPropertyName("customer_group_id")]
    public int? CustomerGroupId { get; set; }

    [JsonPropertyName("date_created")]
    public BcDateTime? DateCreated { get; set; }

    [JsonPropertyName("date_modified")]
    public BcDateTime? DateModified { get; set; }

    [JsonPropertyName("address_count")]
    public int? AddressCount { get; set; }

    [JsonPropertyName("attribute_count")]
    public int? AttributeCount { get; set; }

    [JsonPropertyName("authentication")]
    public Authentication? Authentication { get; set; }

    [JsonPropertyName("attributes")]
    public List<BcCustomerAttribute>? Attributes { get; set; }

    [JsonPropertyName("store_credit_amounts")]
    public List<BcStoreCreditAmounts>? StoreCreditAmounts { get; set; }

    [JsonPropertyName("accepts_product_review_abandoned_cart_emails")]
    public bool? AcceptsProductReviewAbandonedCartEmails { get; set; }
    
    [JsonPropertyName("addresses")]
    public List<BcCustomerAddress>? Addresses { get; set; }

    [JsonPropertyName("origin_channel_id")]
    public int? OriginChannelId { get; set; }

    [JsonPropertyName("channel_ids")]
    public List<int>? ChannelIds { get; set; }
}