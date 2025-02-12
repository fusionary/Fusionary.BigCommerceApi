namespace Fusionary.BigCommerce.Operations.Customers;

public class BcCustomer
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
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
    public BcDateTime DateCreated { get; set; }
    
    [JsonPropertyName("date_modified")]
    public BcDateTime DateModified { get; set; }
    
    [JsonPropertyName("address_count")]
    public int? AddressCount { get; set; }
    
    [JsonPropertyName("attribute_count")]
    public int? AttributeCount { get; set; }
    
    [JsonPropertyName("authentication")]
    public Authentication? Authentication { get; set; }

    [JsonPropertyName("attributes")]
    public List<CustomerAttribute>? Attributes { get; set; }
}

public class Authentication
{
    [JsonPropertyName("force_password_reset")]
    public bool? ForcePasswordReset { get; set; }
}

public class CustomerAddress
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("customer_id")]
    public int CustomerId { get; set; }
    
    [JsonPropertyName("first_name")]
    public required string FirstName { get; set; }
    
    [JsonPropertyName("last_name")]
    public required string LastName { get; set; }
    
    [JsonPropertyName("company")]
    public string? Company { get; set; }
    
    [JsonPropertyName("address1")]
    public required string Address1 { get; set; }
    
    [JsonPropertyName("address2")]
    public string? Address2 { get; set; }
    
    [JsonPropertyName("city")]
    public required string City { get; set; }
    
    [JsonPropertyName("state_or_province")]
    public required string StateOrProvince { get; set; }
    
    [JsonPropertyName("postal_code")]
    public required string PostalCode { get; set; }
    
    [JsonPropertyName("country")]
    public required string Country { get; set; }
    
    [JsonPropertyName("country_code")]
    public required string CountryCode { get; set; }
    
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }
    
    [JsonPropertyName("address_type")]
    public string? AddressType { get; set; }
}

public class CustomerAttribute
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("attribute_id")]
    public int AttributeId { get; set; }
    
    [JsonPropertyName("attribute_value")]
    public string? AttributeValue { get; set; }
    
    [JsonPropertyName("customer_id")]
    public int CustomerId { get; set; }
    
    [JsonPropertyName("date_created")]
    public BcDateTime DateCreated { get; set; }
    
    [JsonPropertyName("date_modified")]
    public BcDateTime DateModified { get; set; }
}

