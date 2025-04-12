namespace Fusionary.BigCommerce.Types;

public interface IBcExtensionData
{
    /// <summary>
    /// Any properties that do not have a matching member are added to that dictionary during deserialization and written
    /// during serialization.
    /// </summary>
    IDictionary<string, JsonElement>? ExtensionData { get; init; }
}