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
    /// Handles payment processing and related operations.
    /// </summary>
    internal class PaymentService
    {
        #region Fields
        /// <summary>
        /// Path to the JSON file where payment data is stored.
        /// </summary>
        private static readonly string FilePath = @"C:\PROJETO\TP_POO_25457-main\Data\payments.json";

        /// <summary>
        /// List containing all the payments.
        /// </summary>
        private static List<Payment> paymentList = new List<Payment>();
        #endregion

        #region Constructor
        /// <summary>
        /// Static constructor to initialize the payment list from the JSON file.
        /// </summary>
        static PaymentService()
        {
            if (File.Exists(FilePath))
            {
                paymentList = LoadPaymentsFromJson();
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds a new payment to the system.
        /// </summary>
        /// <param name="payment">The payment object to add.</param>
        /// <returns>A success message indicating the payment was added.</returns>
        public static string AddPayment(Payment payment)
        {
            // Assign a new PaymentId
            payment.PaymentId = paymentList.Count > 0 ? paymentList.Max(p => p.PaymentId) + 1 : 1;
            paymentList.Add(payment);
            SavePaymentsToJson();

            // Update related reservation and accommodation
            var reservation = ReservationService.GetReservations().FirstOrDefault(r => r.Id == payment.Reservation.Id);
            if (reservation != null)
            {
                UpdateReservationAndAccommodation(reservation);
            }

            return "Payment added successfully!";
        }

        /// <summary>
        /// Updates a reservation and marks the associated accommodation as available.
        /// </summary>
        /// <param name="reservation">The reservation object to update.</param>
        private static void UpdateReservationAndAccommodation(Reservation reservation)
        {
            if (reservation != null && reservation.Accommodation != null)
            {
                // Remove the reservation
                ReservationService.RemoveReservation(reservation.Id);

                // Update the accommodation status to "Available"
                reservation.Accommodation.Status = AccommodationStatus.Available;
                AccommodationService.AddOrUpdateAccommodation(reservation.Accommodation);
            }
            else
            {
                Console.WriteLine("Error: Reservation or accommodation is null during update.");
            }
        }

        /// <summary>
        /// Loads payments from the JSON file.
        /// </summary>
        /// <returns>A list of payments loaded from the JSON file.</returns>
        private static List<Payment> LoadPaymentsFromJson()
        {
            try
            {
                var jsonData = File.ReadAllText(FilePath);
                var payments = JsonSerializer.Deserialize<List<Payment>>(jsonData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }) ?? new List<Payment>();

                // Re-associate reservations with their references, if available
                var reservations = ReservationService.GetReservations();
                foreach (var payment in payments)
                {
                    if (payment.Reservation != null)
                    {
                        payment.Reservation = reservations.FirstOrDefault(r => r.Id == payment.Reservation.Id);
                        if (payment.Reservation == null)
                        {
                            Console.WriteLine($"Warning: Reservation with ID {payment.Reservation.Id} not found.");
                        }
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
        /// Removes a payment by its ID.
        /// </summary>
        /// <param name="paymentId">The ID of the payment to remove.</param>
        /// <returns>A message indicating success or failure.</returns>
        public static string RemovePayment(int paymentId)
        {
            var payment = paymentList.FirstOrDefault(p => p.PaymentId == paymentId);
            if (payment == null)
            {
                return "Payment not found.";
            }

            if (payment.Reservation != null && payment.Reservation.Accommodation != null)
            {
                // Update the accommodation status to "Available"
                payment.Reservation.Accommodation.Status = AccommodationStatus.Available;
                AccommodationService.AddOrUpdateAccommodation(payment.Reservation.Accommodation);
            }

            paymentList.Remove(payment);
            SavePaymentsToJson();
            return "Payment removed successfully!";
        }

        /// <summary>
        /// Edits the details of an existing payment.
        /// </summary>
        /// <param name="updatedPayment">The updated payment object.</param>
        /// <returns>A message indicating success or failure.</returns>
        public static string EditPayment(Payment updatedPayment)
        {
            var payment = paymentList.FirstOrDefault(p => p.PaymentId == updatedPayment.PaymentId);
            if (payment == null)
            {
                return "Payment not found.";
            }

            payment.Reservation = updatedPayment.Reservation;
            payment.Amount = updatedPayment.Amount;
            payment.PaymentDate = updatedPayment.PaymentDate;
            payment.Status = updatedPayment.Status;

            SavePaymentsToJson();
            return "Payment edited successfully!";
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
                throw new Exception("Payment not found.");
            }
        }

        /// <summary>
        /// Saves the payment list to the JSON file.
        /// </summary>
        private static void SavePaymentsToJson()
        {
            var jsonData = JsonSerializer.Serialize(paymentList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, jsonData);
        }

        /// <summary>
        /// Retrieves all payments from the system.
        /// </summary>
        /// <returns>A list of all payments.</returns>
        public static List<Payment> GetPayments()
        {
            // Check if the list is empty and load from JSON if necessary
            if (paymentList == null || !paymentList.Any())
            {
                paymentList = LoadPaymentsFromJson();
            }
            return paymentList ?? new List<Payment>();
        }
        #endregion
    }
}
