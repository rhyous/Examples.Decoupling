// See https://aka.ms/new-console-template for more information
using App;
using LibraryA;
using LibraryB;

// Start composition root.
// Use Pure Dependency Injection - no DI/IoC library or framework.
var b = new B();
var concreteDoSomethingEvent = new ConcreteDoSomethingEvent(b); // <-- B is injected as the concrete implementation of IB.
var a = new A(concreteDoSomethingEvent); // <-- Concrete is in App and is injected
// End composition root

// Running
a.DoSomething(); // Will still call B.DoSomething(), just with zero coupling.
