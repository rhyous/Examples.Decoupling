namespace LibraryA.Interfaces
{
    /// <summary>An interface for serializing an object.</summary>
    /// <remarks>
    /// Notice! This is not implemented in LibraryA, it is implemented in the App.
    /// </remarks>
    public interface ISerializer
    {
        T Deserialize<T>(string serializedObject);
        string Serialize<T>(T obj);
    }
}
