namespace Fusionary.BigCommerce.Types;

public record BcMetafield : BcMetafieldPost
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int Id { get; set; }

    public BcResourceType? ResourceType { get; set; }

    public int ResourceId { get; set; }

    public BcDateTime? DateCreated { get; set; }

    public BcDateTime? DateModified { get; set; }
}
