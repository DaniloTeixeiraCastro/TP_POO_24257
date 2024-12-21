using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Tourist_Accommodation_System.Models;

namespace Tourist_Accommodation_System.Services
{
    /// <summary>
    /// Manages accommodation data and operations.
    /// </summary>
    public static class AccommodationService
    {
        private static readonly string FilePath = @"C:\PROJETO\TP_POO_25457-main\Data\accommodations.json";
        private static List<Accommodation> accommodationList = new List<Accommodation>();

        
        static AccommodationService()
        {
            if (!File.Exists(FilePath))
            {
                accommodationList = GenerateDefaultAccommodations();
                SaveAccommodationsToJson();
            }
            else
            {
                accommodationList = LoadAccommodationsFromJson();
            }
        }

        /// <summary>
        /// Get the accommodations list
        /// </summary>
        public static List<Accommodation> GetAccommodations()
        {
         var today = DateTime.Today;

         // Updating status from each room
             foreach (var accommodation in accommodationList)
         {
              accommodation.Status = IsRoomOccupied(accommodation, today)
            ? AccommodationStatus.Occupied
            : AccommodationStatus.Available;
         }

         return accommodationList;
}

        /// <summary>
        /// Add and update an existent accommodation.
        /// </summary>
        /// <param name="accommodation">Accommodation to be updated.</param>
        /// <returns>Success or error message</returns>
        public static string AddOrUpdateAccommodation(Accommodation accommodation)
        {
            
            string validation = ValidateAccommodationData(
                accommodation.Name,
                accommodation.Type.ToString(),
                accommodation.RoomNumber.ToString(),
                accommodation.Capacity.ToString(),
                accommodation.PricePerNight.ToString()
            );
            if (!string.IsNullOrEmpty(validation)) return validation;

            // Verifica duplicação pelo número do quarto
            var existingAccommodation = accommodationList.FirstOrDefault(a => a.RoomNumber == accommodation.RoomNumber);
            if (existingAccommodation != null && existingAccommodation != accommodation)
            {
                return $"O quarto número {accommodation.RoomNumber} já existe.";
            }

            // Add or update an accommodation
            if (existingAccommodation != null)
            {
                
                UpdateAccommodationProperties(accommodation, existingAccommodation);

            }
            else
            {
                
                accommodationList.Add(accommodation);
            }

            SaveAccommodationsToJson();
            return "Acomodação salva com sucesso!";
        }

        /// <summary>
        /// Verify if room is occupied
        /// </summary>
        public static bool IsRoomOccupied(Accommodation accommodation, DateTime date)
        {
            var reservations = ReservationService.GetReservations();
            return reservations.Any(r => r.Accommodation.RoomNumber == accommodation.RoomNumber &&
                                          r.CheckInDate <= date &&
                                          r.CheckOutDate > date); // Verifica se a data está no intervalo
        }

        /// <summary>
        /// Remove an accommodation by the RoomNumber
        /// </summary>
        public static string RemoveAccommodation(int roomNumber)
        {
            var accommodation = accommodationList.FirstOrDefault(a => a.RoomNumber == roomNumber);
            if (accommodation == null) return "Quarto não encontrado.";

            accommodationList.Remove(accommodation);
            SaveAccommodationsToJson();
            return "Quarto removido com sucesso!";
        }

        /// <summary>
        /// Filter accommodations basing on criteria.
        /// </summary>
        public static List<Accommodation> FilterAccommodations(
            AccommodationType? type = null,
            AccommodationStatus? status = null,
            decimal? minPrice = null,
            decimal? maxPrice = null)
        {
            foreach (var accommodation in accommodationList)
            {
                Console.WriteLine($"Room: {accommodation.RoomNumber}, Type: {accommodation.Type}, Status: {accommodation.Status}");
            }
            return accommodationList.Where(a =>
                (type == null || a.Type == type) &&
                (status == null || a.Status == status) &&
                (minPrice == null || a.PricePerNight >= minPrice) &&
                (maxPrice == null || a.PricePerNight <= maxPrice)
            ).ToList();
        }

        /// <summary>
        /// Validate data
        /// </summary>
        private static string ValidateAccommodationData(string name, string type, string roomNumberText, string capacityText, string priceText)
        {
            if (string.IsNullOrWhiteSpace(name)) return "O campo 'Name' deve ser preenchido.";
            if (string.IsNullOrWhiteSpace(type)) return "O campo 'Type' deve ser preenchido.";
            if (!int.TryParse(roomNumberText, out _)) return "O campo 'Room Number' deve conter apenas números.";
            if (!int.TryParse(capacityText, out _)) return "O campo 'Capacity' deve conter apenas números.";
            if (!decimal.TryParse(priceText, out _)) return "O campo 'Price Per Night' deve ser numérico.";

            return string.Empty;
        }

        /// <summary>
        /// Copy proprieties from one accommodation to another
        /// </summary>
        private static void UpdateAccommodationProperties(Accommodation source, Accommodation target)
        {
            target.Name = source.Name;
            target.Type = source.Type;
            target.Capacity = source.Capacity;
            target.PricePerNight = source.PricePerNight;
            target.Status = source.Status;
        }

        /// <summary>
        /// Load accommodaions list from JSON
        /// </summary>
        private static List<Accommodation> LoadAccommodationsFromJson()
        {
            try
            {
                if (!File.Exists(FilePath))
                    return new List<Accommodation>();

                var jsonData = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<Accommodation>>(jsonData) ?? new List<Accommodation>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar os dados do JSON: {ex.Message}");
                return new List<Accommodation>();
            }
        }

        /// <summary>
        /// Save accommodations list to JSON
        /// </summary>
        private static void SaveAccommodationsToJson()
        {
            var directory = Path.GetDirectoryName(FilePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            var jsonData = JsonSerializer.Serialize(accommodationList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, jsonData);
        }

        /// <summary>
        /// Gera a lista de acomodações padrão.
        /// </summary>
        private static List<Accommodation> GenerateDefaultAccommodations()
        {
            var accommodations = new List<Accommodation>();

            // Quartos duplos com vista jardim (15)
            for (int i = 1; i <= 15; i++)
            {
                accommodations.Add(new Accommodation
                {
                    Name = $"Quarto Duplo Vista Jardim {i}",
                    Type = AccommodationType.DoubleRoomGardenView,
                    RoomNumber = i,
                    Capacity = 2,
                    PricePerNight = 50,
                    Status = AccommodationStatus.Available
                });
            }

            // Quartos duplos com vista piscina (10)
            for (int i = 16; i <= 25; i++)
            {
                accommodations.Add(new Accommodation
                {
                    Name = $"Quarto Duplo Vista Piscina {i}",
                    Type = AccommodationType.DoubleRoomPoolView,
                    RoomNumber = i,
                    Capacity = 2,
                    PricePerNight = 50 * 1.25m,
                    Status = AccommodationStatus.Available
                });
            }

            // Quartos triplos (5)
            for (int i = 26; i <= 30; i++)
            {
                accommodations.Add(new Accommodation
                {
                    Name = i == 30 ? $"Quarto Triplo Vista Piscina {i}" : $"Quarto Triplo Vista Jardim {i}",
                    Type = i == 30 ? AccommodationType.TripleRoomPoolView : AccommodationType.TripleRoomGardenView,
                    RoomNumber = i,
                    Capacity = 3,
                    PricePerNight = i == 30 ? 50 * 1.75m : 50 * 1.5m,
                    Status = AccommodationStatus.Available
                });
            }

            return accommodations;
        }
    }
}
