// See https://aka.ms/new-console-template for more information
using App;
using AutoMapper;
using LibraryA;
using LibraryB.Implementation1;
using LibraryB.Implementation2;
using LibraryB.Interfaces;
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
var mySettings = new MySettings(args);
var mapper = new Mapper(config);
IB b = null;
if (mySettings.BImpl == typeof(LibraryB.Implementation1.B))
    b = new LibraryB.Implementation1.B();
if (mySettings.BImpl == typeof(LibraryB.Implementation2.B))
    b = new LibraryB.Implementation1.B();
var concreteDoSomethingEvent = new ConcreteSomethingProvider(b, mapper); // <-- B is injected as the concrete implementation of IB.
var a = new A(concreteDoSomethingEvent); // <-- Concrete is in App and is injected
// End composition root

// Running
var something = a.ReturnSomething(); // Will still call B.DoSomething(), just with zero coupling.
Console.WriteLine($"Something: {JsonSerializer.Serialize(something)}");
