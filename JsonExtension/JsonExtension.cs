using System.Text;
using System.Text.Json;

namespace JsonExtension
{
    public static class JsonExtension
    {
        public static T ToJson<T>(this string value)
        {
            T result = JsonSerializer.Deserialize<T>(value, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return result;
        }

        public static T ToJson<T>(this string value, JsonSerializerOptions? options)
        {
            options.PropertyNameCaseInsensitive = true;

            T result = JsonSerializer.Deserialize<T>(value, options);

            return result;
        }

        public static bool IsJson(this string value)
        {
            JsonDocument json;

            var reader = new Utf8JsonReader(Encoding.UTF8.GetBytes(value));

            var isJson = JsonDocument.TryParseValue(ref reader, out json);

            return isJson;
        }
    }
}
