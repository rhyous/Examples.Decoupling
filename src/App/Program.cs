// See https://aka.ms/new-console-template for more information
using App.JsonImplementations;
using LibraryA;
using LibraryB;

// Start composition root.
// Use Pure Dependency Injection - no DI/IoC library or framework.
var jsonSerializerA1 = new JsonSerializerForANewtonSoft();
var jsonSerializerA2 = new JsonSerializerForASystemTextJson();
var jsonSerializerB1 = new JsonSerializerForBNewtonSoft();
var jsonSerializerB2 = new JsonSerializerForBSystemTextJson();

var a1 = new A(jsonSerializerA1) { Name = "A1" };
var a2 = new A(jsonSerializerA2) { Name = "A2" };
var b1 = new B(jsonSerializerB1) { Name = "B1" };
var b2 = new B(jsonSerializerB2) { Name = "B2" };

// End composition root

// Running
a1.Serialize();
a2.Serialize();
b1.Serialize();
b2.Serialize();
