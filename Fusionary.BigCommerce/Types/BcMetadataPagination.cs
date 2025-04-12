namespace Fusionary.BigCommerce.Types;

public record BcMetadataPagination: BcMetadataEmpty
{
    private BcPagination? _pagination;

    [JsonPropertyName("pagination")]
    public BcPagination Pagination
    {
        get => LazyInitializer.EnsureInitialized(ref _pagination, () => new BcPagination());
        set => _pagination = value;
    }
}