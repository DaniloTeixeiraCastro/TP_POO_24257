namespace Tourist_Accommodation_System.Models
{
    /// <summary>
    /// Represents a review made by a client or anonymously.
    /// </summary>
    public class Review
    {
        #region Properties

        /// <summary>
        /// Unique identifier for the review.
        /// </summary>
        public int ReviewId { get; set; }

        /// <summary>
        /// The client who made the review. 
        /// Can be null if the review is anonymous.
        /// </summary>
        public Client? Client { get; set; }

        /// <summary>
        /// Comment provided in the review.
        /// </summary>
        public string Comment { get; set; } = string.Empty;

        /// <summary>
        /// Rating provided in the review (1 to 5 stars).
        /// </summary>
        public ReviewRating Rating { get; set; }

        /// <summary>
        /// Indicates whether the review was made anonymously.
        /// </summary>
        public bool IsAnonymous { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Review() { }

        /// <summary>
        /// Constructor to initialize a review object.
        /// </summary>
        /// <param name="reviewId">Unique identifier for the review.</param>
        /// <param name="client">Associated client (optional).</param>
        /// <param name="comment">Review comment.</param>
        /// <param name="rating">Rating (1 to 5 stars).</param>
        /// <param name="isAnonymous">Indicates if the review is anonymous.</param>
        public Review(int reviewId, Client? client, string comment, ReviewRating rating, bool isAnonymous)
        {
            ReviewId = reviewId;
            Client = client; // Can be null if anonymous
            Comment = comment;
            Rating = rating;
            IsAnonymous = isAnonymous;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns a detailed description of the review.
        /// </summary>
        /// <returns>A string describing the review.</returns>
        public string GetDescription()
        {
            if (IsAnonymous)
            {
                return $"[Anonymous] Review: {Comment}, Rating: {Rating} stars.";
            }
            return $"[Client: {Client?.Name ?? "No name"}] Review: {Comment}, Rating: {Rating} stars.";
        }

        #endregion
    }
}
