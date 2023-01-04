namespace Fusionary.BigCommerce.Types;

public record BcPagedResult<TData> : BcResult<List<TData>, BcMetadataPagination>
{
    private List<TData>? _data;

    public new List<TData> Data
    {
        get => LazyInitializer.EnsureInitialized(ref _data);
        set => _data = value;
    }

    public void Deconstruct(out List<TData> data, out BcPagination pagination)
    {
        data = Data;
        pagination = Meta.Pagination;
    }
}