using System.Text.Json;

public static class Objeto
{
    public static string ObjectToString<T>(T obj)
    {
        if (obj == null) return null;
        return JsonSerializer.Serialize(obj);
    }

    public static T StringToObject<T>(string json)
    {
        if (string.IsNullOrEmpty(json)) return default(T);
        return JsonSerializer.Deserialize<T>(json);
    }
} 