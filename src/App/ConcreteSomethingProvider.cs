using AutoMapper;
using LibraryA;
using LibraryA.Interfaces;
using LibraryA.Models;
using LibraryB.Interfaces;

namespace App
{
    /// <summary>The concrete implementation of LibraryA.ISomethingProvider.</summary>
    /// <remarks>
    /// This is an example of dependency inversion. Instead of A depending on another class,
    /// the concrete implementor depends on LibraryA.IDoSomethingEvent.
    ///</remarks>
    internal class ConcreteSomethingProvider : ISomethingProvider
    {
        private readonly IB _b;
        private readonly IMapper _mapper;

        public ConcreteSomethingProvider(IB b, IMapper mapper)
        {
            _b = b;
            _mapper = mapper;
        }
        public Something ReturnSomething()
        {
            // Convert occurs here
            var bSomething = _b.ReturnSomething();
            return _mapper.Map<Something>(bSomething);
        }
    }
}
