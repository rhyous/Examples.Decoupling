using LibraryA.Interfaces;
using LibraryB.Interfaces;

namespace App
{
    /// <summary>The concrete implementation of LibraryA.IDoSomethingEvent.</summary>
    /// <remarks>
    /// This is an example of dependency inverstion. Instead of A depending on another class,
    /// the concrete implementor depends on LibraryA.IDoSomethingEvent.
    ///</remarks>
    internal class ConcreteDoSomethingEvent : IDoSomethingEvent
    {
        private readonly IB _b;

        public ConcreteDoSomethingEvent(IB b)
        {
            _b = b;
        }
        public void DoSomething()
        {
            _b.DoSomething();
        }
    }
}
