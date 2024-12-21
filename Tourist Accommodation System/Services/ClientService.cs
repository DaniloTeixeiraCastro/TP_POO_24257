using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using System.Text.RegularExpressions;
using Tourist_Accommodation_System.Models;

namespace Tourist_Accommodation_System.Services
{
    /// <summary>
    /// Provides services for client validation and management.
    /// </summary>
    public static class ClientService
    {
        #region Fields
        /// <summary>
        /// Path to the JSON file where client data is stored.
        /// </summary>
        private static readonly string FilePath = @"C:\PROJETO\TP_POO_25457-main\Data\clients.json";

        /// <summary>
        /// List containing all the clients.
        /// </summary>
        private static List<Client> clientList = new List<Client>();
        #endregion

        #region Methods for Validation
        /// <summary>
        /// Checks if a given birth date corresponds to an adult (18 years or older).
        /// </summary>
        /// <param name="birthDate">The birth date of the client.</param>
        /// <returns>True if the client is an adult, otherwise false.</returns>
        public static bool IsAdult(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (birthDate > DateTime.Now.AddYears(-age)) age--;
            return age >= 18;
        }

        /// <summary>
        /// Validates if the provided email address has a correct format.
        /// </summary>
        /// <param name="email">The email address to validate.</param>
        /// <returns>True if the email is valid, otherwise false.</returns>
        public static bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return mail.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if a provided name is valid (contains no numeric characters).
        /// </summary>
        /// <param name="name">The name to validate.</param>
        /// <returns>True if the name is valid, otherwise false.</returns>
        public static bool IsValidName(string name)
        {
            return !Regex.IsMatch(name, @"\d");
        }

        /// <summary>
        /// Verifies if all required fields in the client object are filled.
        /// </summary>
        /// <param name="client">The client to validate.</param>
        /// <returns>True if all fields are valid, otherwise false.</returns>
        public static bool AreFieldsValid(Client client)
        {
            return !string.IsNullOrWhiteSpace(client.Name) &&
                   !string.IsNullOrWhiteSpace(client.Email) &&
                   !string.IsNullOrWhiteSpace(client.Phone) &&
                   !string.IsNullOrWhiteSpace(client.TIN) &&
                   client.BirthDate != default;
        }

        /// <summary>
        /// Validates all fields of a client object and returns an error message if any field is invalid.
        /// </summary>
        /// <param name="client">The client to validate.</param>
        /// <returns>An error message if validation fails, otherwise an empty string.</returns>
        public static string ValidateClient(Client client)
        {
            if (!IsAdult(client.BirthDate))
                return "The client must be at least 18 years old.";

            if (!IsValidEmail(client.Email))
                return "The provided email is invalid.";

            if (!IsValidName(client.Name))
                return "The client's name cannot contain numbers.";

            if (!AreFieldsValid(client))
                return "All client fields must be filled.";

            return string.Empty; // No errors
        }
        #endregion

        #region CRUD Operations
        /// <summary>
        /// Adds a new client to the system after validation.
        /// </summary>
        /// <param name="client">The client to add.</param>
        /// <returns>A success message or an error message if validation fails.</returns>
        public static string AddClient(Client client)
        {
            // Validate the client
            string validationResult = ValidateClient(client);
            if (!string.IsNullOrEmpty(validationResult))
                return validationResult;

            // Ensure the list is updated before adding
            clientList = GetClients();

            if (clientList.Any(c => c.Email == client.Email || c.TIN == client.TIN))
                return "A client with this email or TIN already exists.";

            // Automatically generate the next ID
            client.Id = clientList.Count > 0 ? clientList.Max(c => c.Id) + 1 : 1;

            // Add the client to the list and save to JSON
            clientList.Add(client);
            SaveClientsToJson();
            return "Client successfully added!";
        }

        /// <summary>
        /// Updates an existing client's information.
        /// </summary>
        /// <param name="updatedClient">The updated client object.</param>
        public static void UpdateClient(Client updatedClient)
        {
            var client = clientList.FirstOrDefault(c => c.Id == updatedClient.Id);
            if (client != null)
            {
                client.Name = updatedClient.Name;
                client.Email = updatedClient.Email;
                client.Phone = updatedClient.Phone;
                client.TIN = updatedClient.TIN;
                client.BirthDate = updatedClient.BirthDate;

                SaveClientsToJson(); // Update the JSON data
            }
        }

        /// <summary>
        /// Removes a client from the system by their ID.
        /// </summary>
        /// <param name="clientId">The ID of the client to remove.</param>
        /// <returns>A message indicating success or failure.</returns>
        public static string RemoveClient(int clientId)
        {
            var client = clientList.FirstOrDefault(c => c.Id == clientId);
            if (client == null)
            {
                return "Client not found.";
            }

            clientList.Remove(client);
            SaveClientsToJson(); // Update the JSON file
            return "Client successfully removed.";
        }

        /// <summary>
        /// Retrieves a list of all clients.
        /// </summary>
        /// <returns>A list of all clients.</returns>
        public static List<Client> GetClients()
        {
            if (clientList.Count == 0)
            {
                clientList = LoadClientsFromJson();
            }
            return clientList;
        }
        #endregion

        #region JSON Handling
        /// <summary>
        /// Saves the client list to a JSON file.
        /// </summary>
        private static void SaveClientsToJson()
        {
            var directory = Path.GetDirectoryName(FilePath);
            if (!string.IsNullOrEmpty(directory))
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory); // Create the directory if it doesn't exist
                }
            }

            var jsonData = JsonSerializer.Serialize(clientList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, jsonData); // Write data to the JSON file
        }

        /// <summary>
        /// Loads the client list from a JSON file.
        /// </summary>
        /// <returns>A list of clients loaded from the file.</returns>
        private static List<Client> LoadClientsFromJson()
        {
            if (!File.Exists(FilePath))
            {
                Console.WriteLine("Client file not found. Creating a new one.");
                return new List<Client>();
            }

            try
            {
                var jsonData = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<Client>>(jsonData) ?? new List<Client>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading clients from JSON: {ex.Message}");
                return new List<Client>();
            }
        }
        #endregion
    }
}
