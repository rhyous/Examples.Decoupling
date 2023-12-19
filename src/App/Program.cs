// See https://aka.ms/new-console-template for more information
using App;
using AutoMapper;
using LibraryA;
using LibraryB;
using System.Text.Json;

// Start composition root.
// Use Pure Dependency Injection - no DI/IoC library or framework.

// AutoMapper
var config = new MapperConfiguration(cfg =>
    {
        // Map source to destination
        cfg.CreateMap<LibraryB.Models.Something, LibraryA.Models.Something>()
           // Comment out this line and see that Title and Name don't map
           .ForMember(dstA => dstA.Name, srcB => srcB.MapFrom(src => src.Title))
           // This line is only needed to go in reverse and isn't used in this example.
           .ReverseMap(); 
    });
var mapper = new Mapper(config);

var b = new B();
var concreteDoSomethingEvent = new ConcreteSomethingProvider(b, mapper); // <-- B is injected as the concrete implementation of IB.
var a = new A(concreteDoSomethingEvent); // <-- Concrete is in App and is injected
// End composition root

// Running
var something = a.ReturnSomething(); // Will still call B.DoSomething(), just with zero coupling.
Console.WriteLine($"Something: {JsonSerializer.Serialize(something)}");
