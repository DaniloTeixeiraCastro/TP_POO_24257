namespace Tourist_Accommodation_System.Models

{
    /// <summary>
    /// Represents a check-in process for a client at an accommodation.
    /// </summary>
    public class CheckIn
    {
        #region Properties

        /// <summary>
        /// The client performing the check-in.
        /// </summary>
        public Client Client { get; set; }

        /// <summary>
        /// The accommodation where the check-in is taking place.
        /// </summary>
        public Accommodation Accommodation { get; set; }

        /// <summary>
        /// The date and time of the check-in.
        /// </summary>
        public DateTime CheckInDateTime { get; set; }

        /// <summary>
        /// Indicates whether the check-in process is completed.
        /// Default is false.
        /// </summary>
        public bool IsCompleted { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor to initialize a check-in object.
        /// </summary>
        /// <param name="client">The client performing the check-in.</param>
        /// <param name="accommodation">The accommodation for the check-in.</param>
        /// <param name="checkInDateTime">The date and time of the check-in.</param>
        public CheckIn(Client client, Accommodation accommodation, DateTime checkInDateTime)
        {
            Client = client;
            Accommodation = accommodation;
            CheckInDateTime = checkInDateTime;
            IsCompleted = false; // By default, the check-in is initially not completed.
        }

        #endregion

        #region Methods

        /// <summary>
        /// Marks the check-in process as completed.
        /// </summary>
        public void CompleteCheckIn()
        {
            IsCompleted = true;
        }

        #endregion
    }
}
