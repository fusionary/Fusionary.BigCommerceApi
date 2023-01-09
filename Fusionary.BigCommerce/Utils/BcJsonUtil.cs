using System.Net.Http.Json;

namespace Fusionary.BigCommerce.Utils;

public static class BcJsonUtil
{
    public static readonly BcSnakeCaseNamingPolicy SnakeCaseNamingPolicy = new();

    public static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = SnakeCaseNamingPolicy,
        DictionaryKeyPolicy = SnakeCaseNamingPolicy,
        Converters =
        {
            new JsonStringEnumMemberConverter(SnakeCaseNamingPolicy),
            new JsonStringEnumConverter(SnakeCaseNamingPolicy)
        },
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    public static JsonContent CreateContent(object? payload) => JsonContent.Create(payload, options: JsonOptions);

    public static FormUrlEncodedContent CreateFormContent(object? payload) => new(ToDictionary(payload));

    public static T? Deserialize<T>(string json) => JsonSerializer.Deserialize<T>(json, JsonOptions);

    public static string Serialize<T>(T value, bool writeIndented = false) =>
        JsonSerializer.Serialize(
            value,
            writeIndented
                ? new JsonSerializerOptions(JsonOptions) { WriteIndented = writeIndented }
                : JsonOptions
        );

    public static Dictionary<string, string> ToDictionary(object? value)
    {
        var json = JsonSerializer.Serialize(value, JsonOptions);
        var dictionary = JsonSerializer.Deserialize<Dictionary<string, object>>(json, JsonOptions) ??
                         new Dictionary<string, object>();
        return dictionary.ToDictionary(k => k.Key, v => $"{v.Value}");
    }
}