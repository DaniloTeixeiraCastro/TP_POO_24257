using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

public static class DataStorageService
{
    private static readonly string BaseDirectory = @"C:\PROJETO\TP_POO_25457-main";

    // Método para guardar dados em JSON
    public static void SaveToJson<T>(T data, string fileName)
    {
        // Garante que o diretório existe
        if (!Directory.Exists(BaseDirectory))
        {
            Directory.CreateDirectory(BaseDirectory);
        }

        // Caminho completo do ficheiro
        string filePath = Path.Combine(BaseDirectory, fileName);

        // Serializa os dados para JSON e guarda no ficheiro
        var options = new JsonSerializerOptions { WriteIndented = true };
        var jsonData = JsonSerializer.Serialize(data, options);
        File.WriteAllText(filePath, jsonData);
    }

    // Método para carregar dados de JSON
    public static T LoadFromJson<T>(string fileName)
    {
        string filePath = Path.Combine(BaseDirectory, fileName);

        if (!File.Exists(filePath))
            throw new FileNotFoundException($"O ficheiro {filePath} não foi encontrado!");

        var jsonData = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<T>(jsonData) ?? throw new InvalidOperationException("Erro ao deserializar o JSON. O arquivo pode estar corrompido.");
    }
}

