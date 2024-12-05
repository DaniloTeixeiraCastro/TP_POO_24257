    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;
    namespace Tourist_Accommodation_System.Models
{
    public class Accommodation : Entity
    {
        public string Name { get; set; }  // Nome do alojamento
        public string Location { get; set; }  // Localização
        public int RoomNumber { get; set; }  // Número do quarto
        public int Capacity { get; set; }  // Capacidade máxima
        public decimal PricePerNight { get; set; }  // Preço por noite
        public bool IsAvailable { get; set; } = true;  // Disponibilidade do quarto

        public Accommodation() { }

        public Accommodation(int id, string name, string location, int roomNumber, int capacity, decimal pricePerNight)
        {
            Id = id;
            Name = name;
            Location = location;
            RoomNumber = roomNumber;
            Capacity = capacity;
            PricePerNight = pricePerNight;
        }

        public override string GetDescription()
        {
            return $"Room {RoomNumber}: {Name} in {Location}, Capacity: {Capacity}, Price per Night: {PricePerNight:C}, Available: {IsAvailable}";
        }
    }
}
