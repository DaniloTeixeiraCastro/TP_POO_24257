namespace Tourist_Accommodation_System.Models
{
    /// <summary>
    /// Representa uma avaliação feita por um cliente ou anonimamente.
    /// </summary>
    public class Review
    {
        /// <summary>
        /// Identificador único da avaliação.
        /// </summary>
        public int ReviewId { get; set; }

        /// <summary>
        /// Cliente que fez a avaliação. 
        /// Pode ser null se a avaliação for anônima.
        /// </summary>
        public Client? Client { get; set; }

        /// <summary>
        /// Comentário escrito na avaliação.
        /// </summary>
        public string Comment { get; set; } = string.Empty;

        /// <summary>
        /// Classificação dada à avaliação.
        /// </summary>
        public ReviewRating Rating { get; set; }

        /// <summary>
        /// Indica se a avaliação foi feita de forma anônima.
        /// </summary>
        public bool IsAnonymous { get; set; }

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public Review() { }

        /// <summary>
        /// Construtor para inicializar a avaliação.
        /// </summary>
        /// <param name="reviewId">Identificador único da avaliação.</param>
        /// <param name="client">Cliente associado (opcional).</param>
        /// <param name="comment">Comentário do cliente.</param>
        /// <param name="rating">Classificação (1 a 5 estrelas).</param>
        /// <param name="isAnonymous">Indica se a avaliação é anônima.</param>
        public Review(int reviewId, Client? client, string comment, ReviewRating rating, bool isAnonymous)
        {
            ReviewId = reviewId;
            Client = client; // Pode ser null se for anônimo
            Comment = comment;
            Rating = rating;
            IsAnonymous = isAnonymous;
        }

        /// <summary>
        /// Retorna uma descrição detalhada da avaliação.
        /// </summary>
        public string GetDescription()
        {
            if (IsAnonymous)
            {
                return $"[Anônimo] Avaliação: {Comment}, Classificação: {Rating} estrelas.";
            }
            return $"[Cliente: {Client?.Name ?? "Sem nome"}] Avaliação: {Comment}, Classificação: {Rating} estrelas.";
        }
    }
}
