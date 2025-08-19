namespace Fusionary.BigCommerce.B2B.Types;

public record B2BMetadataPagination : BcMetadataMessage
{
    private B2BPagination? _pagination;
    
    [JsonPropertyName("pagination")]
    public B2BPagination Pagination
    {
        get => LazyInitializer.EnsureInitialized(ref _pagination, () => new B2BPagination());
        set => _pagination = value;
    }
}