using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Accommodation_System.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }  // Identificador único do pagamento
        public Reservation Reservation { get; set; }  // Reserva associada ao pagamento
        public decimal Amount { get; set; }  // Quantidade paga
        public DateTime PaymentDate { get; set; }  // Data do pagamento
        public PaymentStatus Status { get; set; }  // Estado do pagamento
        public PaymentMethod Method { get; set; }  //método pagamento

        // Construtor para inicializar o pagamento
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
