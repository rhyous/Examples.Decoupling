// See https://aka.ms/new-console-template for more information
using LibraryA;

var a = new A();
// A is coupled to B and C. Notice this coupling is hidden from the App.
// Someone using App might not be aware that C is a new dependency.
// What would happen if only the App, LibraryA, and LibraryB are installed?
a.DoSomething(); 
