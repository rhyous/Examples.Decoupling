using LibraryA.Interfaces;
using LibraryA.Models;

namespace LibraryA
{
    public class A : IA
    {
        private readonly ISomethingProvider _somethingProvider;

        // We now are following SOLID, and depending on only an interface.
        public A(ISomethingProvider doSomethingEvent)
        {
            _somethingProvider = doSomethingEvent;
        }

        public Something ReturnSomething()
        {
            // All coupling to both IB or B is gone!
            // Responsibilities
            // 1. DoSomething() - this is the only responsiblity it should have.
            Console.WriteLine($"{nameof(A)} will return something!");
            return _somethingProvider.ReturnSomething();
        }
    }
}