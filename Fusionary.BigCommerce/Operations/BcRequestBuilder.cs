using System.ComponentModel;

namespace Fusionary.BigCommerce.Operations;

public abstract class BcRequestBuilder : IBcRequestBuilder
{
    protected BcRequestBuilder(IBcApi api)
    {
        Api = api;
        Filter = BcFilter.Create();
        Options = new BcRequestOptions();
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public BcFilter Filter { get; }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public IBcApi Api { get; }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public BcRequestOptions Options { get; }
}