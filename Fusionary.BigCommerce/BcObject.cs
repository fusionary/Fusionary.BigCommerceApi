using System.Text.Json;

using JetBrains.Annotations;

namespace Fusionary.BigCommerce;

[UsedImplicitly]
public class BcObject : Dictionary<string, object>
{
    public int Id => GetValue<int>("id");

    public string GetValue(string key) => GetValue<string>(key, "");

    public T GetValue<T>(string key, T defaultValue = default!) where T : notnull
    {
        if (!TryGetValue(key, out var value))
        {
            return defaultValue;
        }

        return value switch
        {
            T t => t,
            JsonElement element => element.Deserialize<T>() ?? defaultValue,
            _ => (T)value
        };
    }

    public string ToJson() => JsonSerializer.Serialize(this);

    public override string ToString() => ToJson();
}