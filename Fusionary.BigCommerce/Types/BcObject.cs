using System.Text.Json;

using JetBrains.Annotations;

namespace Fusionary.BigCommerce.Types;

[UsedImplicitly]
public class BcObject : Dictionary<string, object>
{
    public int Id
    {
        get => GetValue<int>("id");
        set => this["id"] = value;
    }

    private static T ConvertToValue<T>(object value, T defaultValue) where T : notnull =>
        value switch
        {
            T t => t,
            JsonElement element => element.Deserialize<T>() ?? defaultValue,
            _ => (T)value
        };

    public string GetValue(string key) => GetValue<string>(key, "");

    public T GetValue<T>(string key, T defaultValue = default!) where T : notnull =>
        TryGetValue(key, out var value)
            ? ConvertToValue(value, defaultValue)
            : defaultValue;

    public string ToJson() => JsonSerializer.Serialize(this);

    public override string ToString() => ToJson();
}