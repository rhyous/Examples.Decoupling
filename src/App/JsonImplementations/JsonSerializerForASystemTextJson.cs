using LibraryA.Interfaces;
using System.Text.Json;

namespace App.JsonImplementations
{
    internal class JsonSerializerForASystemTextJson : ISerializer
    {
        public T Deserialize<T>(string serializedObject)
        {
            return JsonSerializer.Deserialize<T> (serializedObject);
        }

        public string Serialize<T>(T obj)
        {
            return JsonSerializer.Serialize<T>(obj);
        }
    }
}
