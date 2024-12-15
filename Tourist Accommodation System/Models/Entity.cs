namespace Tourist_Accommodation_System.Models
{
    /// <summary>
    /// Base class for entities with a unique identifier.
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Unique identifier for the entity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Default constructor for standard initialization or deserialization.
        /// </summary>
        public Entity() { }

        /// <summary>
        /// Constructor that accepts an ID.
        /// </summary>
        /// <param name="id">Unique identifier for the entity.</param>
        public Entity(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Abstract method to get a textual description of the entity.
        /// Must be implemented by derived classes.
        /// </summary>
        /// <returns>A string description of the entity.</returns>
        public abstract string GetDescription();
    }
}
