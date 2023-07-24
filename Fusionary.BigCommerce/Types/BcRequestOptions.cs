namespace Fusionary.BigCommerce.Types;

public record BcRequestOptions
{
    private BcRequestOverride? _requestOverrides;

    public BcRequestOverride RequestOverrides
    {
        get => LazyInitializer.EnsureInitialized(ref _requestOverrides);
        set => _requestOverrides = value;
    }
}
