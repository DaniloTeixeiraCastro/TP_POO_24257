namespace Tourist_Accommodation_System.Models
{
    /// <summary>
    /// Represents a reservation in the tourist accommodation system.
    /// </summary>
    public class Reservation
    {
        #region Properties

        /// <summary>
        /// Unique identifier for the reservation.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Client who made the reservation.
        /// </summary>
        public Client Client { get; set; }

        /// <summary>
        /// Reserved accommodation.
        /// </summary>
        public Accommodation Accommodation { get; set; }

        /// <summary>
        /// Check-in date for the reservation.
        /// </summary>
        public DateTime CheckInDate { get; set; }

        /// <summary>
        /// Check-out date for the reservation.
        /// </summary>
        public DateTime CheckOutDate { get; set; }

        /// <summary>
        /// Total price of the reservation (calculated automatically).
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Current status of the reservation.
        /// </summary>
        public ReservationStatus Status { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor without parameters.
        /// </summary>
        public Reservation()
        {
        }

        /// <summary>
        /// Constructor to initialize a new reservation.
        /// </summary>
        /// <param name="id">Unique identifier for the reservation.</param>
        /// <param name="client">Client who made the reservation.</param>
        /// <param name="accommodation">Reserved accommodation.</param>
        /// <param name="checkInDate">Check-in date.</param>
        /// <param name="checkOutDate">Check-out date.</param>
        public Reservation(int id, Client client, Accommodation accommodation, DateTime checkInDate, DateTime checkOutDate)
        {
            Id = id;
            Client = client;
            Accommodation = accommodation;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            TotalPrice = CalculateTotalPrice();
            Status = ReservationStatus.Pending; // Initializes the status as "Pending"
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calculates the total price of the stay based on the number of nights and the price per night.
        /// </summary>
        /// <returns>The total price of the stay.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the check-out date is earlier than or equal to the check-in date.
        /// </exception>
        public decimal CalculateTotalPrice()
        {
            // Calculate the number of nights
            int numberOfNights = (CheckOutDate - CheckInDate).Days;

            // Validate the calculation to avoid negative or zero values
            if (numberOfNights <= 0)
                throw new ArgumentException("Check-out date must be later than check-in date.");

            // Calculate the total price
            return numberOfNights * Accommodation.PricePerNight;
        }

        #endregion
    }
}
