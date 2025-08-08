namespace Fusionary.BigCommerce.B2B.Operations;

public abstract class B2BRequestBuilder : BcRequestBuilder
{
    protected B2BRequestBuilder(IBcApi api) : base(api)
    {
        Options.RequestOverrides.IsB2B = true;
    }
}