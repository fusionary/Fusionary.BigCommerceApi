namespace Fusionary.BigCommerce.Types;

public record BcPagination
{
    private BcPaginationLinks? _links;

    public int Total { get; set; }

    public int Count { get; set; }

    public int PerPage { get; set; }

    public int CurrentPage { get; set; }

    public int TotalPages { get; set; }

    public BcPaginationLinks Links
    {
        get => LazyInitializer.EnsureInitialized(ref _links);
        set => _links = value;
    }

    public bool TooMany { get; set; }
}