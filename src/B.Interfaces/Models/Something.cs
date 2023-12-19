namespace LibraryB.Models
{
    /// <summary>A simple model</summary>
    /// <remarks>
    /// Notice:
    /// 1. This model is in the interfaces library. It should be in the interfaces library
    /// or a separate models library. Usually it is fine to models in the interfaces library.
    /// 2. This model appears at first to break the DRY principle as it is duplicate to
    /// LibraryA.Models.Something, however, it doesn't break DRY because both have their own
    /// single repsonsibilities. This is where YAGNI principle fails. You are gonna need your
    /// own models in separate libraries. These models will likely deviate over time.
    /// </remarks>
    public class Something
    {
        public int Id { get; set; }
        /// <remarks>We changed the property to 'Title' from 'Name'.<remarks>
        public string Title { get; set; }
    }
}
