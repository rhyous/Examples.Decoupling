using LibraryB;

namespace LibraryA
{
    public class A
    {
        // It could also be coupled like this
        //private readonly B _b;
        //public A(B b)
        //{
        //    _b = b;
        //}

        public void DoSomething()
        {
            // How do we eliminate this hard coupling to B?
            // This is called the Control Freak antipattern.
            // This breaks the S in SOLID (i.e. Single Responsibility Principle)
            // Responsibilities
            // 1. DoSomething() - this is the only responsiblity it should have.
            // 2. Object instantiation
            // 3. Object lifetime management - what if B needs disposed?
            new B().DoSomething();
            Console.WriteLine($"{nameof(A)} did something!");
        }
    }
}