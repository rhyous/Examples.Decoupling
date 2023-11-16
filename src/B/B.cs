using LibraryB.Interfaces;

namespace LibraryB
{
    public class B : IB
    {
        public void DoSomething()
        {
            Console.WriteLine($"{nameof(B)} did something!");
        }
    }
}