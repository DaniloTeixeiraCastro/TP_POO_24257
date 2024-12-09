using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tourist_Accommodation_System.Models;

namespace Tourist_Accommodation_System.Services
{
    public static class ReviewService
    {
        private static readonly string FilePath = @"C:\PROJETO\TP_POO_25457-main\Data\reviews.json";
        private static List<Review> reviewList = new List<Review>();

        static ReviewService()
        {
            if (File.Exists(FilePath))
            {
                reviewList = LoadReviewsFromJson();
            }
        }

        /// <summary>
        /// Adiciona uma nova avaliação e salva no JSON.
        /// </summary>
        /// <param name="review">Objeto Review a ser adicionado.</param>
        /// <returns>Mensagem de sucesso ou erro.</returns>
        public static string AddReview(Review review)
        {
            // Valida os dados da avaliação
            if (string.IsNullOrWhiteSpace(review.Comment))
                return "O comentário da avaliação não pode estar vazio.";

            if (!Enum.IsDefined(typeof(ReviewRating), review.Rating))
                return "A classificação fornecida é inválida.";

            review.ReviewId = reviewList.Count > 0 ? reviewList.Max(r => r.ReviewId) + 1 : 1;
            reviewList.Add(review);
            SaveReviewsToJson();
            return "Avaliação adicionada com sucesso!";
        }

        /// <summary>
        /// Retorna todas as avaliações.
        /// </summary>
        public static List<Review> GetReviews() => reviewList;

        /// <summary>
        /// Filtra avaliações por cliente.
        /// </summary>
        /// <param name="clientId">ID do cliente.</param>
        public static List<Review> GetReviewsByClient(int clientId)
        {
            return reviewList.Where(r => r.Client != null && r.Client.Id == clientId).ToList();
        }

        /// <summary>
        /// Filtra avaliações por classificação.
        /// </summary>
        /// <param name="rating">Classificação desejada.</param>
        public static List<Review> GetReviewsByRating(ReviewRating rating)
        {
            return reviewList.Where(r => r.Rating == rating).ToList();
        }

        /// <summary>
        /// Filtra avaliações anônimas ou não anônimas.
        /// </summary>
        /// <param name="isAnonymous">Se verdadeiro, retorna apenas avaliações anônimas.</param>
        public static List<Review> GetAnonymousReviews(bool isAnonymous)
        {
            return reviewList.Where(r => r.IsAnonymous == isAnonymous).ToList();
        }

        /// <summary>
        /// Remove uma avaliação pelo ID.
        /// </summary>
        /// <param name="reviewId">ID da avaliação.</param>
        public static string RemoveReview(int reviewId)
        {
            var review = reviewList.FirstOrDefault(r => r.ReviewId == reviewId);
            if (review == null)
            {
                return "Avaliação não encontrada.";
            }

            reviewList.Remove(review);
            SaveReviewsToJson();
            return "Avaliação removida com sucesso!";
        }

        /// <summary>
        /// Carrega as avaliações do arquivo JSON.
        /// </summary>
        private static List<Review> LoadReviewsFromJson()
        {
            try
            {
                var jsonData = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<Review>>(jsonData) ?? new List<Review>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar avaliações: {ex.Message}");
                return new List<Review>();
            }
        }

        /// <summary>
        /// Salva as avaliações no arquivo JSON.
        /// </summary>
        private static void SaveReviewsToJson()
        {
            var jsonData = JsonSerializer.Serialize(reviewList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, jsonData);
        }
    }
}
