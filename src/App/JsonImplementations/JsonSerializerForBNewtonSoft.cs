using LibraryB.Interfaces;
using Newtonsoft.Json;

namespace App.JsonImplementations
{
    internal class JsonSerializerForBNewtonSoft : ISerializer
    {
        public T Deserialize<T>(string serializedObject)
        {
            return JsonConvert.DeserializeObject<T>(serializedObject);
        }

        public string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
