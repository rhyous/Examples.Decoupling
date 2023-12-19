using LibraryB.Interfaces;
using LibraryB.Models;

namespace LibraryB.Implementation1
{
    public class B : IB
    {
        public Something ReturnSomething()
        {
            Console.WriteLine($"{nameof(B)} (impl2) will return something!");
            return new Something { Id = 27, Title = "Something 27" }; 
        }
    }
}