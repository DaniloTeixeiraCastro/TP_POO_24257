using Tourist_Accommodation_System.Interfaces;
using Tourist_Accommodation_System.Models;

namespace Tourist_Accommodation_System.Models
{
    /// <summary>
    /// Represents a client in the tourist accommodation system.
    /// Inherits the unique identifier property from the Entity class.
    /// </summary>
    public class Client : Entity
    {
        #region Properties

        /// <summary>
        /// Name of the client.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Email address of the client.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Phone number of the client.
        /// </summary>
        public string Phone { get; set; } = string.Empty;

        /// <summary>
        /// Tax Identification Number (TIN) of the client.
        /// </summary>
        public string TIN { get; set; } = string.Empty;

        /// <summary>
        /// Birth date of the client.
        /// </summary>
        public DateTime BirthDate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor (necessary for standard initialization and JSON deserialization).
        /// </summary>
        public Client() { }

        /// <summary>
        /// Constructor to initialize all properties of the client.
        /// Includes ":base" to initialize the inherited ID property from the Entity class.
        /// </summary>
        /// <param name="id">Unique identification of the client.</param>
        /// <param name="name">Name of the client.</param>
        /// <param name="email">Email address of the client.</param>
        /// <param name="phone">Phone number of the client.</param>
        /// <param name="tin">Tax Identification Number (TIN).</param>
        /// <param name="birthDate">Birth date of the client.</param>
        public Client(int id, string name, string email, string phone, string tin, DateTime birthDate) : base(id)
        {
            Name = name;
            Email = email;
            Phone = phone;
            TIN = tin;
            BirthDate = birthDate;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns a textual description of the client.
        /// Overrides the abstract GetDescription() method from the Entity base class.
        /// </summary>
        /// <returns>Basic description containing the name and email of the client.</returns>
        public override string GetDescription()
        {
            return $"Client: {Name}, Email: {Email}";
        }

        #endregion
    }
}
