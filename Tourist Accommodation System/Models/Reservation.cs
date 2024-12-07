namespace Tourist_Accommodation_System.Models
{
    public class Reservation
    {
        #region Properties

        /// <summary>
        /// Identificador único da reserva.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Cliente que fez a reserva.
        /// </summary>
        public Client Client { get; set; }

        /// <summary>
        /// Acomodação reservada.
        /// </summary>
        public Accommodation Accommodation { get; set; }

        /// <summary>
        /// Data de check-in da reserva.
        /// </summary>
        public DateTime CheckInDate { get; set; }

        /// <summary>
        /// Data de check-out da reserva.
        /// </summary>
        public DateTime CheckOutDate { get; set; }

        /// <summary>
        /// Preço total da reserva (calculado automaticamente).
        /// </summary>
        public decimal TotalPrice { get; private set; }

        /// <summary>
        /// Estado atual da reserva.
        /// </summary>
        public ReservationStatus Status { get; set; }

        #endregion

        #region Constructors

        public Reservation()
        { 
        //Construtor padrão sem parâmetros
        }

        /// <summary>
        /// Construtor para inicializar uma nova reserva.
        /// </summary>
        /// <param name="id">Identificador da reserva.</param>
        /// <param name="client">Cliente que fez a reserva.</param>
        /// <param name="accommodation">Acomodação reservada.</param>
        /// <param name="checkInDate">Data de check-in.</param>
        /// <param name="checkOutDate">Data de check-out.</param>
        public Reservation(int id, Client client, Accommodation accommodation, DateTime checkInDate, DateTime checkOutDate)
        {
            Id = id;
            Client = client;
            Accommodation = accommodation;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            TotalPrice = CalculateTotalPrice();
            Status = ReservationStatus.Pending; // Inicializa o estado como "Pending"
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calcula o preço total da estadia com base no número de noites e no preço por noite.
        /// </summary>
        /// <returns>O preço total da estadia.</returns>
        private decimal CalculateTotalPrice()
        {
            // Calcula o número de noites
            int numberOfNights = (CheckOutDate - CheckInDate).Days;

            // Valida o cálculo para evitar valores negativos
            if (numberOfNights <= 0)
                throw new ArgumentException("A data de check-out deve ser posterior à data de check-in.");

            // Calcula o preço total
            return numberOfNights * Accommodation.PricePerNight;
        }

        #endregion
    }
}
