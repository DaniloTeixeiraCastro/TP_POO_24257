using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tourist_Accommodation_System.Models;

namespace Tourist_Accommodation_System.Services
{
    public static class ReservationService
    {
        private static readonly string FilePath = @"C:\PROJETO\TP_POO_25457-main\Data\reservations.json";
        private static List<Reservation> reservationList = new List<Reservation>();

        // Construtor estático para carregar reservas do JSON, se existir
        static ReservationService()
        {
            if (File.Exists(FilePath))
            {
                reservationList = LoadReservationsFromJson();
            }
        }

        /// <summary>
        /// Obtém a lista de todas as reservas.
        /// </summary>
        public static List<Reservation> GetReservations() => reservationList;

        /// <summary>
        /// Adiciona uma nova reserva à lista e salva no JSON.
        /// </summary>
        public static string AddReservation(Reservation reservation)
        {
            // Valida se a acomodação está disponível para as datas especificadas
            if (!ValidateAvailability(reservation.Accommodation, reservation.CheckInDate, reservation.CheckOutDate))
            {
                return "O alojamento não está disponível para as datas selecionadas.";
            }

            // Calcula o preço total da reserva
            reservation.TotalPrice = reservation.CalculateTotalPrice();

            // Define um novo ID para a reserva
            reservation.Id = reservationList.Count > 0 ? reservationList.Max(r => r.Id) + 1 : 1;

            // Adiciona a reserva à lista
            reservationList.Add(reservation);

            // Atualiza o status da acomodação para "Occupied"
            reservation.Accommodation.Status = AccommodationStatus.Occupied;
            AccommodationService.AddOrUpdateAccommodation(reservation.Accommodation);

            // Salva a lista de reservas no JSON
            SaveReservationsToJson();
            return "Reserva adicionada com sucesso!";
        }

        /// <summary>
        /// Remove uma reserva pelo ID e salva no JSON.
        /// </summary>
        public static string RemoveReservation(int reservationId)
        {
            // Localiza a reserva pelo ID
            var reservation = reservationList.FirstOrDefault(r => r.Id == reservationId);
            if (reservation == null) return "Reserva não encontrada.";

            // Remove a reserva da lista
            reservationList.Remove(reservation);

            // Atualiza o status da acomodação para "Available" após a remoção
            reservation.Accommodation.Status = AccommodationStatus.Available;
            AccommodationService.AddOrUpdateAccommodation(reservation.Accommodation);

            // Salva a lista de reservas no JSON
            SaveReservationsToJson();
            return "Reserva removida com sucesso!";
        }

        /// <summary>
        /// Atualiza os dados de uma reserva existente.
        /// </summary>
        public static string UpdateReservation(Reservation updatedReservation)
        {
            var reservation = reservationList.FirstOrDefault(r => r.Id == updatedReservation.Id);
            if (reservation == null) return "Reserva não encontrada.";

            if (!ValidateAvailability(updatedReservation.Accommodation, updatedReservation.CheckInDate, updatedReservation.CheckOutDate, updatedReservation.Id))
            {
                return "O alojamento não está disponível para as novas datas.";
            }

            reservation.Client = updatedReservation.Client;
            reservation.Accommodation = updatedReservation.Accommodation;
            reservation.CheckInDate = updatedReservation.CheckInDate;
            reservation.CheckOutDate = updatedReservation.CheckOutDate;
            reservation.Status = updatedReservation.Status;

            SaveReservationsToJson();
            return "Reserva atualizada com sucesso!";
        }

        /// <summary>
        /// Valida se o alojamento está disponível nas datas fornecidas, exceto uma reserva existente (para edição).
        /// </summary>
        public static bool ValidateAvailability(Accommodation accommodation, DateTime checkIn, DateTime checkOut, int? excludeReservationId = null)
        {
            return !reservationList.Any(r =>
                r.Accommodation.RoomNumber == accommodation.RoomNumber &&
                (excludeReservationId == null || r.Id != excludeReservationId) &&
                r.CheckOutDate > checkIn &&
                r.CheckInDate < checkOut);
        }

        /// <summary>
        /// Carrega reservas do arquivo JSON.
        /// </summary>
        private static List<Reservation> LoadReservationsFromJson()
        {
            try
            {
                var jsonData = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<Reservation>>(jsonData) ?? new List<Reservation>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar reservas: {ex.Message}");
                return new List<Reservation>();
            }
        }

        /// <summary>
        /// Salva a lista de reservas no arquivo JSON.
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
    }
}
