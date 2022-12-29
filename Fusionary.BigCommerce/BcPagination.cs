namespace Fusionary.BigCommerce;

public class BcPagination
{
    private Dictionary<string, string>? _links;

    public int Total { get; set; }

    public int Count { get; set; }

    public int PerPage { get; set; }

    public int CurrentPage { get; set; }

    public int TotalPages { get; set; }

    public Dictionary<string, string> Links
    {
        get => LazyInitializer.EnsureInitialized(ref _links, () => new Dictionary<string, string>());
        set => _links = value;
    }

    public bool TooMany { get; set; }
}