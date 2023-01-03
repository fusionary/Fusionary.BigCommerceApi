using System.Net.Http.Json;
using System.Text.Json;

using JorgeSerrano.Json;

namespace Fusionary.BigCommerce.Utils;

public static class BcJsonUtil
{
    public static readonly JsonSnakeCaseNamingPolicy SnakeCaseNamingPolicy = new();
    
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

    public static string Serialize<T>(T value, bool writeIndented = false)
    {
        return JsonSerializer.Serialize(value, writeIndented
            ? new JsonSerializerOptions(JsonOptions) { WriteIndented = writeIndented }
            : JsonOptions);
    }

    public static T? Deserialize<T>(string json)
    {
        return JsonSerializer.Deserialize<T>(json, JsonOptions);
    }
    
    public static JsonContent CreateContent(object? payload)
    {
        return JsonContent.Create(payload, options: JsonOptions);
    }
}