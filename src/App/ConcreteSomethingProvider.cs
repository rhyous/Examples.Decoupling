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

        public ConcreteSomethingProvider(IB b)
        {
            _b = b;
        }
        public Something ReturnSomething()
        {
            // Convert occurs here
            var bSomething = _b.ReturnSomething();
            return new Something 
            {
                Id = bSomething.Id,
                Name = bSomething.Name
            };
        }
    }
}
