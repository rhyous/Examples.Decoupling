using LibraryA.Models;

namespace LibraryA.Interfaces
{
    /// <summary>An interface for an a provider that will be called.</summary>
    /// <remarks>
    /// Notice! This is not implemented in LibraryA, it is implemented in the App.
    /// </remarks>
    public interface ISomethingProvider
    {
        Something ReturnSomething();
    }
}
