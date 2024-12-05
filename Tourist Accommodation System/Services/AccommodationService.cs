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

        // Garante que os 30 quartos padrão sejam carregados inicialmente
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

        public static List<Accommodation> GetAccommodations() => accommodationList;

        //metodo para adicionar quartos
        public static string AddOrUpdateAccommodation(Accommodation accommodation)
        {
            // Validação dos campos
            if (string.IsNullOrWhiteSpace(accommodation.Name) ||
                string.IsNullOrWhiteSpace(accommodation.Location) ||
                accommodation.RoomNumber <= 0 ||
                accommodation.Capacity <= 0 ||
                accommodation.PricePerNight <= 0)
            {
                return "Todos os campos devem ser preenchidos corretamente.";
            }

            // Verifica se o número do quarto já existe, exceto se for o mesmo quarto (edição)
            var existingAccommodation = accommodationList.FirstOrDefault(a => a.RoomNumber == accommodation.RoomNumber);
            if (existingAccommodation != null && existingAccommodation != accommodation)
            {
                return $"O quarto número {accommodation.RoomNumber} já existe.";
            }

            if (existingAccommodation != null)
            {
                // Atualiza os dados do quarto existente
                existingAccommodation.Name = accommodation.Name;
                existingAccommodation.Location = accommodation.Location;
                existingAccommodation.Capacity = accommodation.Capacity;
                existingAccommodation.PricePerNight = accommodation.PricePerNight;
                existingAccommodation.IsAvailable = accommodation.IsAvailable;
            }
            else
            {
                // Adiciona um novo quarto
                accommodationList.Add(accommodation);
            }

            SaveAccommodationsToJson(); // Atualiza o JSON
            return "Acomodação salva com sucesso!";
        }
        //metodo para atualizar os quartos editados
        public static void UpdateAccommodation(Accommodation updatedAccommodation)
        {
            var accommodation = accommodationList.FirstOrDefault(a => a.RoomNumber == updatedAccommodation.RoomNumber);
            if (accommodation != null)
            {
                accommodation.Name = updatedAccommodation.Name;
                accommodation.Location = updatedAccommodation.Location;
                accommodation.Capacity = updatedAccommodation.Capacity;
                accommodation.PricePerNight = updatedAccommodation.PricePerNight;
                accommodation.IsAvailable = updatedAccommodation.IsAvailable;

                SaveAccommodationsToJson();
            }
        }
        public static string RemoveAccommodation(int roomNumber)
        {
            var accommodation = accommodationList.FirstOrDefault(a => a.RoomNumber == roomNumber);
            if (accommodation == null)
                return "Acomodação não encontrada.";

            accommodationList.Remove(accommodation);
            SaveAccommodationsToJson();
            return "Acomodação removida com sucesso!";
        }

        //listagem de quartos do json
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
        private static void SaveAccommodationsToJson()
        {
            var directory = Path.GetDirectoryName(FilePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            var jsonData = JsonSerializer.Serialize(accommodationList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, jsonData);
        }

        //listagem de quartos default
        private static List<Accommodation> GenerateDefaultAccommodations()
        {
            var accommodations = new List<Accommodation>();

            // Quartos duplos com vista jardim (15)
            for (int i = 1; i <= 15; i++)
            {
                accommodations.Add(new Accommodation
                {
                    Name = $"Quarto Duplo Vista Jardim {i}",
                    Location = "Vista Jardim",
                    RoomNumber = i,
                    Capacity = 2,
                    PricePerNight = 50 // Preço base
                });
            }

            // Quartos duplos com vista piscina (10, 25% mais caros)
            for (int i = 16; i <= 25; i++)
            {
                accommodations.Add(new Accommodation
                {
                    Name = $"Quarto Duplo Vista Piscina {i}",
                    Location = "Vista Piscina",
                    RoomNumber = i,
                    Capacity = 2,
                    PricePerNight = 50 * 1.25m // 25% mais caro
                });
            }

            // Quartos triplos (5)
            for (int i = 26; i <= 30; i++)
            {
                bool isPoolView = i == 30; // Apenas o último tem vista piscina
                accommodations.Add(new Accommodation
                {
                    Name = isPoolView ? $"Quarto Triplo Vista Piscina {i}" : $"Quarto Triplo {i}",
                    Location = isPoolView ? "Vista Piscina" : "Vista Jardim",
                    RoomNumber = i,
                    Capacity = 3,
                    PricePerNight = isPoolView ? 50 * 1.75m : 50 * 1.5m // 50% mais caros (75%) para vista piscina
                });
            }

            return accommodations;
        }

        private static bool IsRoomNumberDuplicated(int roomNumber) => accommodationList.Any(a => a.RoomNumber == roomNumber);

        //metodo para validar os campos preenchidos
        public static string ValidateAccommodationData(string name, string location, string roomNumberText, string capacityText, string priceText)
        {
            if (string.IsNullOrWhiteSpace(name)) return "O campo 'Name' deve ser preenchido.";
            if (string.IsNullOrWhiteSpace(location)) return "O campo 'Location' deve ser preenchido.";
            if (!int.TryParse(roomNumberText, out _)) return "O campo 'Room Number' deve conter apenas números.";
            if (!int.TryParse(capacityText, out _)) return "O campo 'Capacity' deve conter apenas números.";
            if (!decimal.TryParse(priceText, out _)) return "O campo 'Price Per Night' deve ser numérico.";

            return string.Empty;
        }

        //metodo para filtragem

    }


}
