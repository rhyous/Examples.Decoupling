using LibraryA.Interfaces;

namespace LibraryA
{
    public class A : IA
    {
        private readonly ISerializer _serializer;

        // We now are following SOLID, and depending on only an interface.
        public A(ISerializer serializer)
        {
            _serializer = serializer;
        }

        public string Name { get; set; }

        public string Serialize()
        {
            // All coupling to Newtonsoft.Json is gone!
            // This coupling can be moved to the App or Composition Root.
            var serializedObject = _serializer.Serialize(this);
            Console.WriteLine($"Serialized Object{Environment.NewLine}{serializedObject}");
            return serializedObject;
        }
    }
}