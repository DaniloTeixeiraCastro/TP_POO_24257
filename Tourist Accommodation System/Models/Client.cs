using Tourist_Accommodation_System.Interfaces;

namespace Tourist_Accommodation_System.Models
{
    public class Client : Entity
    {
        //propriedades da classe
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string TIN { get; set; } = string.Empty; //nif
        public DateTime BirthDate { get; set; } 

        public Client() { }

        // Construtor dos objetos do cliente
        public Client(int id, string name, string email, string phone, string tin, DateTime birthDate)
        {   
            Id = id;    
            Name = name;
            Email = email;
            Phone = phone;
            TIN = tin;
            BirthDate = birthDate;
        }

        public override string GetDescription()
        {
            return $"Client: {Name}, Email: {Email}";
        }

    }
}
