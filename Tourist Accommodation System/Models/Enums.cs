
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Accommodation_System.Models
{
    /// <summary>
    /// Tipos de acomodações disponíveis.
    /// </summary>
    public enum AccommodationType
    {
        /// <summary>
        /// Quarto duplo com vista para o jardim.
        /// </summary>
        DoubleRoomGardenView,

        /// <summary>
        /// Quarto duplo com vista para a piscina.
        /// </summary>
        DoubleRoomPoolView,

        /// <summary>
        /// Quarto triplo com vista para o jardim.
        /// </summary>
        TripleRoomGardenView,

        /// <summary>
        /// Quarto triplo com vista para a piscina.
        /// </summary>
        TripleRoomPoolView
    }

    /// <summary>
    /// Status de disponibilidade de acomodações.
    /// </summary>
    public enum AccommodationStatus
    {
        /// <summary>
        /// O quarto está disponível para reserva.
        /// </summary>
        Available,

        /// <summary>
        /// O quarto está atualmente ocupado.
        /// </summary>
        Occupied
    }

    /// <summary>
    /// Status de um pagamento.
    /// </summary>
    public enum PaymentStatus
    {
        /// <summary>
        /// Pagamento ainda não foi processado.
        /// </summary>
        Pending,

        /// <summary>
        /// Pagamento foi concluído com sucesso.
        /// </summary>
        Completed,

        /// <summary>
        /// O pagamento falhou.
        /// </summary>
        Failed,

        /// <summary>
        /// O pagamento foi reembolsado.
        /// </summary>
        Refunded,

        /// <summary>
        /// Pagamento foi parcialmente concluído.
        /// </summary>
        PartiallyCompleted
    }

    /// <summary>
    /// Status de uma reserva.
    /// </summary>
    public enum ReservationStatus
    {
        /// <summary>
        /// Reserva pendente de confirmação.
        /// </summary>
        Pending,

        /// <summary>
        /// Reserva confirmada e ativa.
        /// </summary>
        Confirmed,

        /// <summary>
        /// Reserva foi cancelada.
        /// </summary>
        Cancelled,

        /// <summary>
        /// Reserva expirou e não é mais válida.
        /// </summary>
        Expired
    }

    /// <summary>
    /// Classificação de avaliações (de 1 a 5 estrelas).
    /// </summary>
    public enum ReviewRating
    {
        /// <summary>
        /// Uma estrela (classificação mais baixa).
        /// </summary>
        OneStar = 1,

        /// <summary>
        /// Duas estrelas.
        /// </summary>
        TwoStars = 2,

        /// <summary>
        /// Três estrelas (classificação média).
        /// </summary>
        ThreeStars = 3,

        /// <summary>
        /// Quatro estrelas.
        /// </summary>
        FourStars = 4,

        /// <summary>
        /// Cinco estrelas (classificação mais alta).
        /// </summary>
        FiveStars = 5
    }

    /// <summary>
    /// Métodos de pagamento disponíveis.
    /// </summary>
    public enum PaymentMethod
    {
        /// <summary>
        /// Pagamento em dinheiro.
        /// </summary>
        Cash,

        /// <summary>
        /// Pagamento com cartão de crédito.
        /// </summary>
        CreditCard,

        /// <summary>
        /// Pagamento com cartão de débito.
        /// </summary>
        DebitCard,

        /// <summary>
        /// Pagamento via transferência bancária.
        /// </summary>
        BankTransfer
    }
}
