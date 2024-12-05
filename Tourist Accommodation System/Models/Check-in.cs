namespace Tourist_Accommodation_System.Models

{
    public class CheckIn
    {
        // Properties
        public Client Client { get; set; }
        public Accommodation Accommodation { get; set; }
        public DateTime CheckInDateTime { get; set; }
        public bool IsCompleted { get; set; }

        // Constructor
        public CheckIn(Client client, Accommodation accommodation, DateTime checkInDateTime)
        {
            Client = client;
            Accommodation = accommodation;
            CheckInDateTime = checkInDateTime;
            IsCompleted = false; // Por padrão, o check-in é inicialmente não concluído
        }

        // Método para concluir o check-in
        public void CompleteCheckIn()
        {
            IsCompleted = true;
        }
    }

}
