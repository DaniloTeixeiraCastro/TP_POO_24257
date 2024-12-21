using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

/// <summary>
/// Provides methods for saving and loading data as JSON files.
/// </summary>
public static class DataStorageService
{
    #region Fields
    /// <summary>
    /// The base directory where JSON files will be saved.
    /// </summary>
    private static readonly string BaseDirectory = @"C:\PROJETO\TP_POO_25457-main";
    #endregion

    #region Methods
    /// <summary>
    /// Saves the specified data to a JSON file.
    /// </summary>
    /// <typeparam name="T">The type of the data to save.</typeparam>
    /// <param name="data">The data to be serialized and saved.</param>
    /// <param name="fileName">The name of the JSON file to save the data in.</param>
    public static void SaveToJson<T>(T data, string fileName)
    {
        // Ensures the directory exists
        if (!Directory.Exists(BaseDirectory))
        {
            Directory.CreateDirectory(BaseDirectory);
        }

        // Full path of the file
        string filePath = Path.Combine(BaseDirectory, fileName);

        // Serialize the data to JSON and save it to the file
        var options = new JsonSerializerOptions { WriteIndented = true };
        var jsonData = JsonSerializer.Serialize(data, options);
        File.WriteAllText(filePath, jsonData);
    }

    /// <summary>
    /// Loads data from a JSON file.
    /// </summary>
    /// <typeparam name="T">The type of the data to load.</typeparam>
    /// <param name="fileName">The name of the JSON file to load the data from.</param>
    /// <returns>The deserialized data of type <typeparamref name="T"/>.</returns>
    /// <exception cref="FileNotFoundException">Thrown if the specified file does not exist.</exception>
    /// <exception cref="InvalidOperationException">Thrown if the JSON file cannot be deserialized.</exception>
    public static T LoadFromJson<T>(string fileName)
    {
        string filePath = Path.Combine(BaseDirectory, fileName);

        if (!File.Exists(filePath))
            throw new FileNotFoundException($"The file {filePath} was not found!");

        var jsonData = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<T>(jsonData) ?? throw new InvalidOperationException("Error deserializing JSON. The file may be corrupted.");
    }
    #endregion
}
