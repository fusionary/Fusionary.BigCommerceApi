namespace Fusionary.BigCommerce.Types;

public class BcApiException : BcException
{
    public BcApiException(string message) : base(message)
    { }

    public BcApiException(string message, Exception innerException) : base(message, innerException)
    { }
}