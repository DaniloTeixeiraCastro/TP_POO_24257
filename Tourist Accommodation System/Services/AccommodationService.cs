using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Tourist_Accommodation_System.Models;

namespace Tourist_Accommodation_System.Services
{
    public static class AccommodationService
    {
        private static readonly string FilePath = @"C:\PROJETO\TP_POO_25457-main\accommodations.json";
        private static List<Accommodation> accommodationList = new List<Accommodation>();

        // Inicialização da classe estática
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
        /// Obtém a lista completa de acomodações.
        /// </summary>
        public static List<Accommodation> GetAccommodations() => accommodationList;

        /// <summary>
        /// Adiciona ou atualiza uma acomodação existente.
        /// </summary>
        /// <param name="accommodation">Acomodação a ser adicionada ou atualizada.</param>
        /// <returns>Mensagem de sucesso ou erro.</returns>
        public static string AddOrUpdateAccommodation(Accommodation accommodation)
        {
            // Validação dos dados
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

            // Atualiza ou adiciona a acomodação
            if (existingAccommodation != null)
            {
                // Atualiza apenas as propriedades modificadas da acomodação
                UpdateAccommodationProperties(accommodation, existingAccommodation);

                // Verifica se houve mudança no status
                if (existingAccommodation.Status != accommodation.Status)
                {
                    existingAccommodation.Status = accommodation.Status;
                }
            }
            else
            {
                // Adiciona uma nova acomodação
                accommodationList.Add(accommodation);
            }

            // Salva a lista de acomodações no JSON
            SaveAccommodationsToJson();
            return "Acomodação salva com sucesso!";
        }

        /// <summary>
        /// Remove uma acomodação da lista pelo número do quarto.
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
        /// Filtra acomodações com base nos critérios fornecidos.
        /// </summary>
        public static List<Accommodation> FilterAccommodations(
            AccommodationType? type = null,
            AccommodationStatus? status = null,
            decimal? minPrice = null,
            decimal? maxPrice = null)
        {
            return accommodationList.Where(a =>
                (type == null || a.Type == type) &&
                (status == null || a.Status == status) &&
                (minPrice == null || a.PricePerNight >= minPrice) &&
                (maxPrice == null || a.PricePerNight <= maxPrice)
            ).ToList();
        }

        /// <summary>
        /// Valida os dados da acomodação.
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
        /// Copia as propriedades de uma acomodação para outra.
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
        /// Carrega a lista de acomodações a partir do JSON.
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
        /// Salva a lista de acomodações no JSON.
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
