using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tourist_Accommodation_System.Models;

namespace Tourist_Accommodation_System.Services
{
    /// <summary>
    /// Provides functionality for managing reviews, including adding, retrieving, filtering, and removing reviews.
    /// </summary>
    public static class ReviewService
    {
        #region Fields
        /// <summary>
        /// Path to the JSON file where review data is stored.
        /// </summary>
        private static readonly string FilePath = @"C:\PROJETO\TP_POO_25457-main\Data\reviews.json";

        /// <summary>
        /// List containing all the reviews.
        /// </summary>
        private static List<Review> reviewList = new List<Review>();
        #endregion

        #region Constructor
        /// <summary>
        /// Static constructor to load reviews from the JSON file, if it exists.
        /// </summary>
        static ReviewService()
        {
            if (File.Exists(FilePath))
            {
                reviewList = LoadReviewsFromJson();
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds a new review and saves it to the JSON file.
        /// </summary>
        /// <param name="review">The review object to add.</param>
        /// <returns>A message indicating the success or failure of the operation.</returns>
        public static string AddReview(Review review)
        {
            if (string.IsNullOrWhiteSpace(review.Comment))
                return "The review comment cannot be empty.";

            if (!Enum.IsDefined(typeof(ReviewRating), review.Rating))
                return "The provided rating is invalid.";

            review.ReviewId = reviewList.Count > 0 ? reviewList.Max(r => r.ReviewId) + 1 : 1;
            reviewList.Add(review);
            SaveReviewsToJson();
            return "Review added successfully!";
        }

        /// <summary>
        /// Retrieves all reviews.
        /// </summary>
        /// <returns>A list of all reviews.</returns>
        public static List<Review> GetReviews() => reviewList;

        /// <summary>
        /// Filters reviews by client ID.
        /// </summary>
        /// <param name="clientId">The ID of the client whose reviews are to be retrieved.</param>
        /// <returns>A list of reviews associated with the specified client.</returns>
        public static List<Review> GetReviewsByClient(int clientId)
        {
            return reviewList.Where(r => r.Client != null && r.Client.Id == clientId).ToList();
        }

        /// <summary>
        /// Filters reviews by rating.
        /// </summary>
        /// <param name="rating">The desired rating.</param>
        /// <returns>A list of reviews matching the specified rating.</returns>
        public static List<Review> GetReviewsByRating(ReviewRating rating)
        {
            return reviewList.Where(r => r.Rating == rating).ToList();
        }

        /// <summary>
        /// Filters reviews by anonymity status.
        /// </summary>
        /// <param name="isAnonymous">True to retrieve anonymous reviews, false for non-anonymous reviews.</param>
        /// <returns>A list of reviews filtered by anonymity status.</returns>
        public static List<Review> GetAnonymousReviews(bool isAnonymous)
        {
            return reviewList.Where(r => r.IsAnonymous == isAnonymous).ToList();
        }

        /// <summary>
        /// Removes a review by its ID.
        /// </summary>
        /// <param name="reviewId">The ID of the review to remove.</param>
        /// <returns>A message indicating the success or failure of the operation.</returns>
        public static string RemoveReview(int reviewId)
        {
            var review = reviewList.FirstOrDefault(r => r.ReviewId == reviewId);
            if (review == null)
            {
                return "Review not found.";
            }

            reviewList.Remove(review);
            SaveReviewsToJson();
            return "Review removed successfully!";
        }

        /// <summary>
        /// Loads reviews from the JSON file.
        /// </summary>
        /// <returns>A list of reviews loaded from the file.</returns>
        private static List<Review> LoadReviewsFromJson()
        {
            try
            {
                var jsonData = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<Review>>(jsonData) ?? new List<Review>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading reviews: {ex.Message}");
                return new List<Review>();
            }
        }

        /// <summary>
        /// Saves the review list to the JSON file.
        /// </summary>
        private static void SaveReviewsToJson()
        {
            var jsonData = JsonSerializer.Serialize(reviewList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, jsonData);
        }
        #endregion
    }
}
