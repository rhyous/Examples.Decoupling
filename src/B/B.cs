using LibraryB.Interfaces;

namespace LibraryB
{
    public class B : IB
    {
        private readonly Interfaces.ISerializer _serializer;

        public B(ISerializer serializer)
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