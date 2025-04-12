using System.Reflection;

namespace Fusionary.BigCommerce;

public static class ExtensionsForEnum
{
    public static T FromValue<T>(this string? value) where T : struct
    {
        var type = typeof(T);

        foreach (var field in type.GetFields())
        {
            if (field.GetCustomAttribute<JsonPropertyNameAttribute>() is { } attr &&
                TryGetEnumValue(value, attr.Name, field, out T enumValue))
            {
                return enumValue;
            }
        }

        return ParseEnumFromValue<T>(value);
    }

    private static T ParseEnumFromValue<T>(string? value) where T : struct
    {
        const bool ignoreCase = true;
        return Enum.TryParse(value, ignoreCase, out T result) ? result : default;
    }

    public static string ToValue<T>(this T value) where T : struct
    {
        var type = typeof(T);

        var stringValue = value.ToString() ?? string.Empty;

        var field = type.GetFields()
            .FirstOrDefault(x => string.Equals(x.Name, stringValue, StringComparison.OrdinalIgnoreCase));

        return field?.GetCustomAttribute<JsonPropertyNameAttribute>() is { } jsonPropertyNameAttribute
            ? jsonPropertyNameAttribute.Name
            : stringValue;
    }

    private static bool TryGetEnumValue<T>(string? value, string? name, FieldInfo field, out T enumValue)
        where T : struct
    {
        enumValue = default;

        if (!string.Equals(name, value, StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        var fieldValue = field.GetValue(null);

        if (fieldValue is null)
        {
            return false;
        }

        enumValue = (T)fieldValue;
        return true;
    }
}