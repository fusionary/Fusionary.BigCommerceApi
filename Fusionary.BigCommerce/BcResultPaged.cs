namespace Fusionary.BigCommerce;

public record BcResultPaged<TData> : BcResult<List<TData>, BcMetadataPagination>
{
    private List<TData>? _data;

    public new List<TData> Data
    {
        get => LazyInitializer.EnsureInitialized(ref _data);
        set => _data = value;
    }

    [JsonIgnore]
    public BcPagination Pagination => Meta?.Pagination!;

    /// <summary>
    /// <see langword="true" /> if <see cref="Data"/> has 1 or more items.
    /// </summary>
    [JsonIgnore]
    public new bool HasData => Data.Count > 0;

    public bool HasNextPage => !string.IsNullOrWhiteSpace(Pagination?.Links?.Next);

    public bool HasPreviousPage => !string.IsNullOrWhiteSpace(Pagination?.Links?.Previous);

    public void Deconstruct(out List<TData> data, out BcPagination pagination)
    {
        data = Data;
        pagination = Pagination;
    }
}