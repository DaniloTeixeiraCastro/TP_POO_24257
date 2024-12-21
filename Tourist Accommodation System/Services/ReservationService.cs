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
    /// Manages operations related to reservations, including adding, updating, and removing reservations.
    /// </summary>
    public static class ReservationService
    {
        #region Fields
        /// <summary>
        /// Path to the JSON file where reservation data is stored.
        /// </summary>
        private static readonly string FilePath = @"C:\PROJETO\TP_POO_25457-main\Data\reservations.json";

        /// <summary>
        /// List containing all the reservations.
        /// </summary>
        private static List<Reservation> reservationList = new List<Reservation>();
        #endregion

        #region Constructor
        /// <summary>
        /// Static constructor to load reservations from the JSON file, if it exists.
        /// </summary>
        static ReservationService()
        {
            if (File.Exists(FilePath))
            {
                reservationList = LoadReservationsFromJson();
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Retrieves the list of all reservations.
        /// </summary>
        /// <returns>A list of reservations.</returns>
        public static List<Reservation> GetReservations() => reservationList;

        /// <summary>
        /// Adds a new reservation to the list and saves it to the JSON file.
        /// </summary>
        /// <param name="reservation">The reservation to add.</param>
        /// <returns>A message indicating the success or failure of the operation.</returns>
        public static string AddReservation(Reservation reservation)
        {
            if (!ValidateAvailability(reservation.Accommodation, reservation.CheckInDate, reservation.CheckOutDate))
            {
                return "The accommodation is not available for the selected dates.";
            }

            reservation.TotalPrice = reservation.CalculateTotalPrice();
            reservation.Id = reservationList.Count > 0 ? reservationList.Max(r => r.Id) + 1 : 1;

            reservationList.Add(reservation);
            SaveReservationsToJson();
            return "Reservation added successfully!";
        }

        /// <summary>
        /// Removes a reservation by its ID and saves the changes to the JSON file.
        /// </summary>
        /// <param name="reservationId">The ID of the reservation to remove.</param>
        /// <returns>A message indicating the success or failure of the operation.</returns>
        public static string RemoveReservation(int reservationId)
        {
            var reservation = reservationList.FirstOrDefault(r => r.Id == reservationId);
            if (reservation == null) return "Reservation not found.";

            reservationList.Remove(reservation);
            reservation.Accommodation.Status = AccommodationStatus.Available;
            AccommodationService.AddOrUpdateAccommodation(reservation.Accommodation);

            SaveReservationsToJson();
            return "Reservation removed successfully!";
        }

        /// <summary>
        /// Updates an existing reservation's details.
        /// </summary>
        /// <param name="updatedReservation">The reservation object with updated details.</param>
        /// <returns>A message indicating the success or failure of the operation.</returns>
        public static string UpdateReservation(Reservation updatedReservation)
        {
            var reservation = reservationList.FirstOrDefault(r => r.Id == updatedReservation.Id);
            if (reservation == null) return "Reservation not found.";

            if (!ValidateAvailability(updatedReservation.Accommodation, updatedReservation.CheckInDate, updatedReservation.CheckOutDate, updatedReservation.Id))
            {
                return "The accommodation is not available for the new dates.";
            }

            reservation.Client = updatedReservation.Client;
            reservation.Accommodation = updatedReservation.Accommodation;
            reservation.CheckInDate = updatedReservation.CheckInDate;
            reservation.CheckOutDate = updatedReservation.CheckOutDate;
            reservation.Status = updatedReservation.Status;

            SaveReservationsToJson();
            return "Reservation updated successfully!";
        }

        /// <summary>
        /// Validates if the accommodation is available for the given dates, excluding a specific reservation ID.
        /// </summary>
        /// <param name="accommodation">The accommodation to validate.</param>
        /// <param name="checkIn">The check-in date.</param>
        /// <param name="checkOut">The check-out date.</param>
        /// <param name="excludeReservationId">An optional reservation ID to exclude from the validation.</param>
        /// <returns>True if the accommodation is available, otherwise false.</returns>
        public static bool ValidateAvailability(Accommodation accommodation, DateTime checkIn, DateTime checkOut, int? excludeReservationId = null)
        {
            return !reservationList.Any(r =>
                r.Accommodation.RoomNumber == accommodation.RoomNumber &&
                (excludeReservationId == null || r.Id != excludeReservationId) &&
                r.CheckOutDate > checkIn &&
                r.CheckInDate < checkOut);
        }

        /// <summary>
        /// Loads reservations from the JSON file.
        /// </summary>
        /// <returns>A list of reservations loaded from the file.</returns>
        private static List<Reservation> LoadReservationsFromJson()
        {
            try
            {
                var jsonData = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<Reservation>>(jsonData) ?? new List<Reservation>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading reservations: {ex.Message}");
                return new List<Reservation>();
            }
        }

        /// <summary>
        /// Saves the reservation list to the JSON file.
        /// </summary>
        private static void SaveReservationsToJson()
        {
            var directory = Path.GetDirectoryName(FilePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var jsonData = JsonSerializer.Serialize(reservationList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, jsonData);
        }
        #endregion
    }
}
