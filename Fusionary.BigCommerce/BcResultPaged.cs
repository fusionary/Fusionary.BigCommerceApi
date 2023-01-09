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

    public void Deconstruct(out List<TData> data, out BcPagination pagination)
    {
        data = Data;
        pagination = Pagination;
    }
}