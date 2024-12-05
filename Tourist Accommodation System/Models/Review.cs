namespace Tourist_Accommodation_System.Models

{
    public class Review
    {
        public int ReviewId { get; set; }
        public Client Client { get; set; }
        public Accommodation Accommodation { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

        public Review(Client client, Accommodation accommodation, int rating, string comment)
        {
            Client = client;
            Accommodation = accommodation;
            Rating = rating;
            Comment = comment;
        }
    }
}
