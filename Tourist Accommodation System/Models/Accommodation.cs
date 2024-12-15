    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;
    namespace Tourist_Accommodation_System.Models
{
    /// <summary>
    /// Represents an accommodation within the tourist system.
    /// Inherits from the base class 'Entity'.
    /// </summary>
    public class Accommodation : Entity
    {
        /// <summary>
        /// Name of the accommodation.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Type of the accommodation (e.g., Hotel, Apartment, etc.).
        /// </summary>
        public AccommodationType? Type { get; set; }

        /// <summary>
        /// Room number associated with the accommodation.
        /// </summary>
        public int RoomNumber { get; set; }

        /// <summary>
        /// Maximum capacity of the accommodation (number of people).
        /// </summary>
        public int Capacity { get; set; }

        /// <summary>
        /// Price per night for the accommodation.
        /// </summary>
        public decimal PricePerNight { get; set; }

        /// <summary>
        /// Current status of the accommodation (e.g., Available, Reserved, etc.).
        /// Default value is 'Available'.
        /// </summary>
        public AccommodationStatus Status { get; set; } = AccommodationStatus.Available;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Accommodation() { }

        /// <summary>
        /// Parameterized constructor to initialize an accommodation object.
        /// </summary>
        /// <param name="id">Unique identifier for the accommodation.</param>
        /// <param name="name">Name of the accommodation.</param>
        /// <param name="type">Type of accommodation.</param>
        /// <param name="roomNumber">Room number associated with the accommodation.</param>
        /// <param name="capacity">Maximum capacity of the accommodation.</param>
        /// <param name="pricePerNight">Price per night for the accommodation.</param>
        /// <param name="status">Status of the accommodation.</param>
        public Accommodation(int id, string name, AccommodationType type, int roomNumber, int capacity, decimal pricePerNight, AccommodationStatus status) : base()
        {
            Id = id;
            Name = name;
            Type = type;
            RoomNumber = roomNumber;
            Capacity = capacity;
            PricePerNight = pricePerNight;
            Status = status;
        }

        /// <summary>
        /// Returns a formatted string describing the accommodation.
        /// </summary>
        /// <returns>A string with details of the accommodation including room number, type, capacity, price, and status.</returns>
        public override string GetDescription()
        {
            return $"Room {RoomNumber}: , Type: {Type}, Capacity: {Capacity}, Price: {PricePerNight:C}, Status: {Status}";
        }
    }

}

