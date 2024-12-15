using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tourist_Accommodation_System.Models;

namespace Tourist_Accommodation_System.Services
{
    internal class PaymentService
    {
        private static readonly string FilePath = @"C:\PROJETO\TP_POO_25457-main\Data\payments.json";
        private static List<Payment> paymentList = new List<Payment>();

        // Construtor estático para carregar pagamentos do JSON
        static PaymentService()
        {
            if (File.Exists(FilePath))
            {
                paymentList = LoadPaymentsFromJson();
            }
        }

        /// <summary>
        /// Adiciona um novo pagamento.
        /// </summary>
        public static string AddPayment(Payment payment)
        {
            // Adiciona o pagamento
            payment.PaymentId = paymentList.Count > 0 ? paymentList.Max(p => p.PaymentId) + 1 : 1;
            paymentList.Add(payment);
            SavePaymentsToJson();

            // Atualiza o status da reserva e do quarto
            UpdateReservationAndAccommodation(payment.Reservation);

            return "Payment added successfully!";
        }

        /// <summary>
        /// Atualiza a reserva e marca o quarto como disponível.
        /// </summary>
        private static void UpdateReservationAndAccommodation(Reservation reservation)
        {
            // Remove a reserva
            ReservationService.RemoveReservation(reservation.Id);

            // Atualiza o status do quarto para "Available"
            reservation.Accommodation.Status = AccommodationStatus.Available;
            AccommodationService.AddOrUpdateAccommodation(reservation.Accommodation);
        }

        /// <summary>
        /// Carrega os pagamentos do arquivo JSON.
        /// </summary>
        private static List<Payment> LoadPaymentsFromJson()
        {
            try
            {
                var jsonData = File.ReadAllText(FilePath);
                var payments = JsonSerializer.Deserialize<List<Payment>>(jsonData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }) ?? new List<Payment>();

                // Re-associa as reservas às suas referências
                var reservations = ReservationService.GetReservations();
                foreach (var payment in payments)
                {
                    if (payment.Reservation != null)
                    {
                        payment.Reservation = reservations.FirstOrDefault(r => r.Id == payment.Reservation.Id);
                    }
                }

                return payments;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading payments: {ex.Message}");
                return new List<Payment>();
            }
        }

        /// <summary>
        /// Remove um pagamento pelo ID.
        /// </summary>
        public static string RemovePayment(int paymentId)
        {
            var payment = paymentList.FirstOrDefault(p => p.PaymentId == paymentId);
            if (payment == null)
            {
                return "Pagamento não encontrado.";
            }

            paymentList.Remove(payment);
            SavePaymentsToJson();
            return "Pagamento removido com sucesso!";
        }

        /// <summary>
        /// Edita os detalhes de um pagamento.
        /// </summary>
        public static string EditPayment(Payment updatedPayment)
        {
            var payment = paymentList.FirstOrDefault(p => p.PaymentId == updatedPayment.PaymentId);
            if (payment == null)
            {
                return "Pagamento não encontrado.";
            }

            payment.Reservation = updatedPayment.Reservation;
            payment.Amount = updatedPayment.Amount;
            payment.PaymentDate = updatedPayment.PaymentDate;
            payment.Status = updatedPayment.Status;

            SavePaymentsToJson();
            return "Pagamento editado com sucesso!";
        }
        /// <summary>
        /// Updates an existing payment in the list and saves it to the JSON file.
        /// </summary>
        /// <param name="updatedPayment">The payment object with updated data.</param>
        public static void UpdatePayment(Payment updatedPayment)
        {
            // Find the payment by ID
            var payment = paymentList.FirstOrDefault(p => p.PaymentId == updatedPayment.PaymentId);
            if (payment != null)
            {
                // Update the payment fields
                payment.Reservation = updatedPayment.Reservation;
                payment.Amount = updatedPayment.Amount;
                payment.PaymentDate = updatedPayment.PaymentDate;
                payment.Status = updatedPayment.Status;
                payment.Method = updatedPayment.Method;

                // Save updated list to JSON
                SavePaymentsToJson();
            }
            else
            {
                throw new Exception("Pagamento não encontrado.");
            }
        }

        /// <summary>
        /// Saves the updated payment list to the JSON file.
        /// </summary>

        /// <summary>
        /// Salva a lista de pagamentos no arquivo JSON.
        /// </summary>
        private static void SavePaymentsToJson()
        {
            var jsonData = JsonSerializer.Serialize(paymentList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, jsonData);
        }
        public static List<Payment> GetPayments()
        {
            // Verifica se a lista está vazia e carrega do JSON, se necessário
            if (paymentList == null || paymentList.Count == 0)
            {
                paymentList = LoadPaymentsFromJson();
            }
            return paymentList;
        }
    }
}
