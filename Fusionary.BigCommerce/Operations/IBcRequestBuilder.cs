namespace Fusionary.BigCommerce.Operations;

public interface IBcRequestBuilder
{
    IBcApi Api { get; }

    BcFilter Filter { get; }

    BcRequestOptions Options { get; }
}