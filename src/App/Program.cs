// See https://aka.ms/new-console-template for more information
using LibraryA;
using LibraryB;

// Start composition root.
// Use Pure Dependency Injection - no DI/IoC library or framework.
var a = new A(new B()); // <-- B is injected as the concrete implementation of IB.
// End composition root

// Running
a.DoSomething(); // Will still call B.DoSomething(), just without hard coupling.
