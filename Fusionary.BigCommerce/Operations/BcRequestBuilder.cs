using System.ComponentModel;

namespace Fusionary.BigCommerce.Operations;

public abstract class BcRequestBuilder(IBcApi api) : IBcRequestBuilder
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public BcFilter Filter { get; } = BcFilter.Create();

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public IBcApi Api { get; } = api;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public BcRequestOptions Options { get; } = new();
}