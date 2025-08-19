namespace Fusionary.BigCommerce.B2B.Types;

public class B2BCompany
{
    [JsonPropertyName("companyName")]
    public string? CompanyName { get; set; }
    [JsonPropertyName("companyEmail")]
    public string? CompanyEmail { get; set; }
    [JsonPropertyName("companyPhone")]
    public string? CompanyPhone { get; set; }
    [JsonPropertyName("companyId")]
    public BcId? CompanyId { get; set; }
    [JsonPropertyName("catalogId")]
    public BcId? CatalogId { get; set;  }
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }
    [JsonPropertyName("bcGroupName")]
    public string? BcGroupName { get; set; }
    [JsonPropertyName("companyStatus")]
    public int? CompanyStatus { get; set; }
    /// <summary>
    /// Note that UUID can't be set on creation, just on update.
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
    [JsonPropertyName("updatedAt")]
    public int? UpdatedAtTimestamp { get; set; }
    [JsonPropertyName("createdAt")]
    public int? CreatedAtTimestamp { get; set; }
    [JsonPropertyName("bcGroupId")]
    public int? BcGroupId { get; set; }
    
    [JsonPropertyName("parentCompany")]
    public B2BCompanyParentCompany? ParentCompany { get; set; }
    
    [JsonPropertyName("priceListAssign")]
    public List<B2BCompanyPriceListAssignment>? PriceListAssignment { get; set; }
    
    [JsonPropertyName("extraFields")]
    public List<B2BCompanyExtraField>? ExtraFields { get; set; }
}