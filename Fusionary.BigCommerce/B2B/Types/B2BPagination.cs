namespace Fusionary.BigCommerce.B2B.Types;

public record B2BPagination
{
    [JsonPropertyName("totalCount")]
    public int? TotalCount { get; init; }
    
    [JsonPropertyName("limit")]
    public int? Limit { get; init; }
    
    [JsonPropertyName("offset")]
    public int? Offset { get; init; }
}