using AutoMapper;
using LibraryA.Interfaces;
using Rhyous.EasyXml;

namespace App.JsonImplementations
{
    internal class XmlSerializerForA : ISerializer
    {
        private readonly IMapper _mapper;

        public XmlSerializerForA(IMapper mapper)
        {
            _mapper = mapper;
        }
        public T Deserialize<T>(string serializedObject)
        {
            return Serializer.DeserializeFromXml<T>(serializedObject);
        }

        public string Serialize<T>(T obj)
        {
            var tmp = _mapper.Map<App.Models.A>(obj);
            return Serializer.SerializeToXml(tmp, true);
        }
    }
}
