using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using System.Text.RegularExpressions;
using Tourist_Accommodation_System.Models;

namespace Tourist_Accommodation_System.Services
{
    public static class ClientService
    {
        private static readonly string FilePath = @"C:\PROJETO\TP_POO_25457-main\Data\clients.json";
        private static List<Client> clientList = new List<Client>();

        public static bool IsAdult(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (birthDate > DateTime.Now.AddYears(-age)) age--;
            return age >= 18;
        }

        public static bool IsValidEmail(string email) //metodo para verificar e-mail
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

        public static bool IsValidName(string name) //metodo para verificar nome
        {
            return !Regex.IsMatch(name, @"\d");
        }

        public static bool AreFieldsValid(Client client)
        {
            return !string.IsNullOrWhiteSpace(client.Name) &&
                   !string.IsNullOrWhiteSpace(client.Email) &&
                   !string.IsNullOrWhiteSpace(client.Phone) &&
                   !string.IsNullOrWhiteSpace(client.TIN) &&
                   client.BirthDate != default;
        }

        // Método para validar todos os campos de um cliente
        public static string ValidateClient(Client client)
        {
            if (!IsAdult(client.BirthDate))
                return "O cliente deve ter pelo menos 18 anos.";

            if (!IsValidEmail(client.Email))
                return "O e-mail fornecido é inválido.";

            if (!IsValidName(client.Name))
                return "O nome do cliente não pode conter números.";

            if (!AreFieldsValid(client))
                return "Todos os campos do cliente devem estar preenchidos.";

            return string.Empty; // Sem erros
        }

        public static string AddClient(Client client) //regras para validação de todos os campos
        {
            // Validação do cliente
            string validationResult = ValidateClient(client);
            if (!string.IsNullOrEmpty(validationResult))
                return validationResult;

            // Garante que a lista esteja atualizada antes de adicionar
            clientList = GetClients();

            if (clientList.Any(c => c.Email == client.Email || c.TIN == client.TIN))
                return "Já existe um cliente com este e-mail ou TIN.";

            // Gera o próximo ID automaticamente
            client.Id = clientList.Count > 0 ? clientList.Max(c => c.Id) + 1 : 1;

            // Adiciona o cliente à lista e salva no JSON
            clientList.Add(client);
            SaveClientsToJson();
            return "Cliente adicionado com sucesso!";
        }

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

                SaveClientsToJson(); // Atualize os dados no JSON
            }
        }

        #region
        public static string RemoveClient(int clientId) //metodo para remover cliente
        {
            var client = clientList.FirstOrDefault(c => c.Id == clientId);
            if (client == null)
            {
                return "Cliente não encontrado.";
            }

            clientList.Remove(client);
            SaveClientsToJson(); // Atualiza o ficheiro JSON
            return "Cliente removido com sucesso.";
        }
        #endregion

        public static List<Client> GetClients()
        {
            if (clientList.Count == 0)
            {
                clientList = LoadClientsFromJson();
            }
            return clientList;
        }
        #region

        private static void SaveClientsToJson() //metodo para guardar os clientes na lsita
        {
            var directory = Path.GetDirectoryName(FilePath);
            if (!string.IsNullOrEmpty(directory)) // Verifica se o diretório não é nulo ou vazio
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory); // Cria o diretório se não existir
                }
            }

            var jsonData = JsonSerializer.Serialize(clientList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, jsonData); // Escreve os dados no arquivo JSON
        }
        #endregion 

        #region
        private static List<Client> LoadClientsFromJson() //metodo para carregar os clientes
        {
            if (!File.Exists(FilePath))
            {
                Console.WriteLine("Ficheiro de clientes não encontrado. Criando um novo.");
                return new List<Client>();
            }

            try
            {
                var jsonData = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<Client>>(jsonData) ?? new List<Client>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar os clientes do JSON: {ex.Message}");
                return new List<Client>();
            }
        }
        #endregion

    }
}

