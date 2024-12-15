    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Accommodation_System.Models
{
    /// <summary>
    /// Represents a payment associated with a reservation.
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// Unique identifier for the payment.
        /// </summary>
        public int PaymentId { get; set; }

        /// <summary>
        /// The reservation associated with the payment.
        /// </summary>
        public Reservation Reservation { get; set; }

        /// <summary>
        /// The amount paid.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// The date when the payment was made.
        /// </summary>
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// The status of the payment (e.g., Pending, Completed, etc.).
        /// </summary>
        public PaymentStatus Status { get; set; }

        /// <summary>
        /// The method used for the payment (e.g., Cash, CreditCard, etc.).
        /// </summary>
        public PaymentMethod Method { get; set; }

        /// <summary>
        /// Constructor to initialize a payment object.
        /// </summary>
        /// <param name="paymentId">Unique identifier for the payment.</param>
        /// <param name="reservation">The reservation associated with the payment.</param>
        /// <param name="amount">The amount paid.</param>
        /// <param name="paymentDate">The date when the payment was made.</param>
        /// <param name="status">The status of the payment.</param>
        /// <param name="method">The method used for the payment.</param>
        public Payment(int paymentId, Reservation reservation, decimal amount, DateTime paymentDate, PaymentStatus status, PaymentMethod method)
        {
            PaymentId = paymentId;
            Reservation = reservation;
            Amount = amount;
            PaymentDate = paymentDate;
            Status = status;
            Method = method;
        }
    }
}
