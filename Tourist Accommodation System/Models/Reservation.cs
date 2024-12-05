namespace Tourist_Accommodation_System.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public Client Client { get; set; }  // O cliente que fez a reserva
        public Accommodation Accommodation { get; set; }  // O alojamento reservado
        public DateTime CheckInDate { get; set; }  // Data de Check-in
        public DateTime CheckOutDate { get; set; }  // Data de Check-out
        public decimal TotalPrice { get; private set; }  // Preço total da reserva (calculado)

        // Construtor para inicializar a reserva
        public Reservation(int id, Client client, Accommodation accommodation, DateTime checkInDate, DateTime checkOutDate)
        {
            Id = id;
            Client = client;
            Accommodation = accommodation;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            TotalPrice = CalculateTotalPrice();  // Calcula o preço total ao criar a reserva
        }


        // Método para calcular o preço total da estadia
        private decimal CalculateTotalPrice()
        {
            // Calcula o número de noites
            int numberOfNights = (CheckOutDate - CheckInDate).Days;

            // Calcula o preço total
            return numberOfNights * Accommodation.PricePerNight;
        }

    }
}
