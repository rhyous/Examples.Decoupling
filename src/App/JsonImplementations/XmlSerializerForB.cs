using AutoMapper;
using LibraryB.Interfaces;
using Rhyous.EasyXml;

namespace App.JsonImplementations
{
    internal class XmlSerializerForB : ISerializer
    {
        private readonly IMapper _mapper;

        public XmlSerializerForB(IMapper mapper)
        {
            _mapper = mapper;
        }
        public T Deserialize<T>(string serializedObject)
        {
            return Serializer.DeserializeFromXml<T>(serializedObject);
        }

        public string Serialize<T>(T obj)
        {
            var tmp = _mapper.Map<App.Models.B>(obj);
            return Serializer.SerializeToXml(tmp, true);
        }
    }
}
