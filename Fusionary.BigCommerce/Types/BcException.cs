namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("{Message,nq}")]
public class BcException : Exception
{
    /// <inheritdoc />
    public BcException(string message) : base(message)
    { }

    /// <inheritdoc />
    public BcException(string message, Exception innerException) : base(message, innerException)
    { }
}