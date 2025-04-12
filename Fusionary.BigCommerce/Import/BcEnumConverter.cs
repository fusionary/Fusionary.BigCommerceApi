using System.Reflection;

using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace Fusionary.BigCommerce.Import;

public class BcEnumConverter : DefaultTypeConverter
{
    private readonly Dictionary<object, string> _attributeNamesByEnumValues = new();
    private readonly Dictionary<string, string> _enumNamesByAttributeNames = new();

    private readonly Dictionary<string, string> _enumNamesByAttributeNamesIgnoreCase =
        new(StringComparer.OrdinalIgnoreCase);

    private readonly Type _type;

    // enumNamesByAttributeNames
    // enumNamesByAttributeNamesIgnoreCase
    // [Name("Foo")]:One

    // attributeNamesByEnumValues
    // 1:[Name("Foo")]

    /// <summary>
    /// Creates a new <see cref="BcEnumConverter" /> for the given <see cref="Enum" /> <see cref="System.Type" />.
    /// </summary>
    /// <param name="type">The type of the Enum.</param>
    public BcEnumConverter(Type type)
    {
        if (!typeof(Enum).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
        {
            throw new ArgumentException($"'{type.FullName}' is not an Enum.");
        }

        _type = type;

        foreach (var value in Enum.GetValues(type))
        {
            var enumName = Enum.GetName(type, value) ?? string.Empty;

            var nameAttribute = type.GetField(enumName)?.GetCustomAttribute<JsonPropertyNameAttribute>();

            if (nameAttribute != null && nameAttribute.Name.Length > 0)
            {
                var attributeName = nameAttribute.Name;

                _enumNamesByAttributeNames.TryAdd(attributeName, enumName);
                _enumNamesByAttributeNamesIgnoreCase.TryAdd(attributeName, enumName);
                _attributeNamesByEnumValues.TryAdd(value, attributeName);
            }
        }
    }

    /// <inheritdoc />
    public override object? ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
    {
        var ignoreCase = memberMapData.TypeConverterOptions.EnumIgnoreCase ?? false;

        if (text != null)
        {
            var dict = ignoreCase
                ? _enumNamesByAttributeNamesIgnoreCase
                : _enumNamesByAttributeNames;

            if (dict.TryGetValue(text, out var name))
            {
                return Enum.Parse(_type, name);
            }
        }

        return Enum.TryParse(_type, text, ignoreCase, out var value)
            ? value
            : base.ConvertFromString(text, row, memberMapData);
    }

    /// <inheritdoc />
    public override string? ConvertToString(object? value, IWriterRow row, MemberMapData memberMapData) =>
        value is not null && _attributeNamesByEnumValues.TryGetValue(value, out var name)
            ? name
            : base.ConvertToString(value, row, memberMapData);
}