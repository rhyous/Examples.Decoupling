using LibraryC;

namespace LibraryB
{
    public class B
    {
        private readonly C _c;

        public B(C c)
        {
            _c = c;
        }

        public void DoSomething()
        {
            _c.DoSomething();
            Console.WriteLine($"{nameof(B)} did something!");
        }
    }
}