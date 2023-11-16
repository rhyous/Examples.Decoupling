using LibraryA.Interfaces;
using LibraryB.Interfaces;

namespace LibraryA
{
    public class A : IA
    {
        // We now are following SOLID, and depending on only an interface.
        private readonly IB _b;
        public A(IB b)
        {
            _b = b;
        }

        public void DoSomething()
        {
            // The hard coupling to B is gone!
            // Responsibilities
            // 1. DoSomething() - this is the only responsiblity it should have.
            _b.DoSomething();
            Console.WriteLine($"{nameof(A)} did something!");
        }
    }
}