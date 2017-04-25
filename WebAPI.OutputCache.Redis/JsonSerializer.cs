using Newtonsoft.Json;

namespace WebAPI.OutputCache.Redis
{
    public class JsonSerializer : IJsonSerializer
    {
        public T DeserializeObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public string SerializeObject<T>(T value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}