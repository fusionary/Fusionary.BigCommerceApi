namespace Fusionary.BigCommerce.Types;

public record BcPagedResponse<TData> : BcResponse<List<TData>, BcMetadataPagination, BcMetaError>
{
    private List<TData>? _data;

    public new List<TData> Data
    {
        get => LazyInitializer.EnsureInitialized(ref _data);
        set => _data = value;
    }
}