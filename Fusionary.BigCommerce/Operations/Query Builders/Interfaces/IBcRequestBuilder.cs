namespace Fusionary.BigCommerce.Operations;

public interface IBcRequestBuilder : IFluentInterface
{
    IBcApi Api { get; }

    BcFilter Filter { get; }

    BcRequestOptions Options { get; }
}