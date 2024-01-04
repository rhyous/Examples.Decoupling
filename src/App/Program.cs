// See https://aka.ms/new-console-template for more information
using App.JsonImplementations;
using AutoMapper;
using LibraryA;
using LibraryB;

// Start composition root.

// Mappers
var config = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<LibraryA.A, App.Models.A>();
    cfg.CreateMap<LibraryB.B, App.Models.B>();
});
var mapper = config.CreateMapper();

// Use Pure Dependency Injection - no DI/IoC library or framework.
var jsonSerializerA1 = new JsonSerializerForANewtonSoft();
var jsonSerializerA2 = new JsonSerializerForASystemTextJson();
var xmlSerializerA3 = new XmlSerializerForA(mapper);
var jsonSerializerB1 = new JsonSerializerForBNewtonSoft();
var jsonSerializerB2 = new JsonSerializerForBSystemTextJson();
var xmlSerializerB3 = new XmlSerializerForB(mapper);

var a1 = new A(jsonSerializerA1) { Name = "A1" };
var a2 = new A(jsonSerializerA2) { Name = "A2" };
var a3 = new A(xmlSerializerA3) { Name = "A3 - Xml" };
var b1 = new B(jsonSerializerB1) { Name = "B1" };
var b2 = new B(jsonSerializerB2) { Name = "B2" };
var b3 = new B(xmlSerializerB3) { Name = "B2 - Xml" };



// End composition root

// Running
a1.Serialize();
a2.Serialize();
a3.Serialize();
b1.Serialize();
b2.Serialize();
b3.Serialize();
