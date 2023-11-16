using LibraryA.Interfaces;

namespace LibraryA
{
    public class A : IA
    {
        private readonly IDoSomethingEvent _doSomethingEvent;

        // We now are following SOLID, and depending on only an interface.
        public A(IDoSomethingEvent doSomethingEvent)
        {
            _doSomethingEvent = doSomethingEvent;
        }

        public void DoSomething()
        {
            // All coupling to both IB or B is gone!
            // Responsibilities
            // 1. DoSomething() - this is the only responsiblity it should have.
            _doSomethingEvent.DoSomething();
            Console.WriteLine($"{nameof(A)} did something!");
        }
    }
}