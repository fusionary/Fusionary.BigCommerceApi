using System.Reflection;
using System.Text.Json;

namespace Fusionary.BigCommerce;

public static class BcEnumExtensions
{
    public static T FromValue<T>(this string? value) where T : struct
    {
        var type = typeof(T);
        foreach (var field in type.GetFields())
        {
            if (field.GetCustomAttribute<JsonPropertyNameAttribute>() is { } jsonPropertyNameAttribute)
            {
                if (TryGetEnumValue(value, jsonPropertyNameAttribute.Name, field, out T enumValue))
                {
                    return enumValue;
                }
            }

            if (field.GetCustomAttribute<EnumMemberAttribute>() is { } enumMemberAttribute)
            {
                if (TryGetEnumValue(value, enumMemberAttribute.Value, field, out T enumValue))
                {
                    return enumValue;
                }
            }
        }

        return ParseEnumFromValue<T>(value);
    }

    public static string ToValue<T>(this T value) where T : struct
    {
        var type = typeof(T);

        string stringValue = value.ToString() ?? string.Empty;
        
        var field = type.GetFields().FirstOrDefault(x => string.Equals(x.Name, stringValue, StringComparison.OrdinalIgnoreCase));

        if (field is not null)
        {
            if (field.GetCustomAttribute<JsonPropertyNameAttribute>() is { } jsonPropertyNameAttribute)
            {
                return jsonPropertyNameAttribute.Name;
            }

            if (field.GetCustomAttribute<EnumMemberAttribute>() is { } enumMemberAttribute)
            {
                return enumMemberAttribute.Value ?? stringValue;
            }
        }

        return stringValue;
    }

    private static T ParseEnumFromValue<T>(string? value) where T : struct => Enum.TryParse(value, true, out T result) ? result : default;

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