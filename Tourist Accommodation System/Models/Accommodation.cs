    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;
    namespace Tourist_Accommodation_System.Models
{
    public class Accommodation : Entity
    {
        // Propriedades da classe
        public string Name { get; set; } // Nome do alojamento
        public string Location { get; set; } // Localização do alojamento
        public AccommodationType Type { get; set; } // Tipo de acomodação
        public int RoomNumber { get; set; } // Número do quarto
        public int Capacity { get; set; } // Capacidade máxima
        public decimal PricePerNight { get; set; } // Preço por noite
        public AccommodationStatus Status { get; set; } = AccommodationStatus.Available; // Status do quarto

        // Construtor padrão
        public Accommodation() { }

        // Construtor para inicializar a acomodação
        public Accommodation(int id, string name, string location, AccommodationType type, int roomNumber, int capacity, decimal pricePerNight, AccommodationStatus status): base()
        
        {
            Id = id;
            Name = name;
            Location = location;
            Type = type;
            RoomNumber = roomNumber;
            Capacity = capacity;
            PricePerNight = pricePerNight;
            Status = status;
        }

        // Método para descrição
        public override string GetDescription()
        {
            return $"Room {RoomNumber}: {Name} in {Location}, Type: {Type}, Capacity: {Capacity}, Price: {PricePerNight:C}, Status: {Status}";
        }
    }

}

