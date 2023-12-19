// See https://aka.ms/new-console-template for more information
using App;
using LibraryA;
using LibraryB;
using System.Text.Json;

// Start composition root.
// Use Pure Dependency Injection - no DI/IoC library or framework.
var b = new B();
var concreteDoSomethingEvent = new ConcreteSomethingProvider(b); // <-- B is injected as the concrete implementation of IB.
var a = new A(concreteDoSomethingEvent); // <-- Concrete is in App and is injected
// End composition root

// Running
var something = a.ReturnSomething(); // Will still call B.DoSomething(), just with zero coupling.
Console.WriteLine($"Something: {JsonSerializer.Serialize(something)}");
