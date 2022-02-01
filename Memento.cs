using Newtonsoft.Json;

namespace pattern_memento
{
    public class Memento<T>
    {
        public string Type { get; set; }

        private readonly string _serializedData;

        public T Object => JsonConvert.DeserializeObject<T>(_serializedData);

        public Memento(T serializeObject){
            Type = typeof(T).ToString();
            _serializedData = JsonConvert.SerializeObject(serializeObject);
        }

    }
}