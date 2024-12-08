using Tourist_Accommodation_System.Interfaces;

namespace Tourist_Accommodation_System.Models
{
    /// <summary>
    /// Representa um cliente do sistema de alojamento turístico.
    /// Herda a propriedade de identificação única da classe Entity.
    /// </summary>
    public class Client : Entity
    {
        // Propriedades da classe
        public string Name { get; set; } = string.Empty; // Nome do cliente
        public string Email { get; set; } = string.Empty; // Endereço de email do cliente
        public string Phone { get; set; } = string.Empty; // Número de telefone do cliente
        public string TIN { get; set; } = string.Empty; // Número de Identificação Fiscal (NIF)
        public DateTime BirthDate { get; set; } // Data de nascimento do cliente

        /// <summary>
        /// Construtor padrão (necessário para inicializações padrão e deserialização JSON).
        /// </summary>
        public Client() { }

        /// <summary>
        /// Construtor que inicializa todas as propriedades do cliente.
        /// Inclui o uso de ":base" para inicializar o ID herdado da classe Entity.
        /// </summary>
        /// <param name="id">Identificação única do cliente.</param>
        /// <param name="name">Nome do cliente.</param>
        /// <param name="email">Endereço de email do cliente.</param>
        /// <param name="phone">Número de telefone do cliente.</param>
        /// <param name="tin">Número de Identificação Fiscal (NIF).</param>
        /// <param name="birthDate">Data de nascimento do cliente.</param>
        public Client(int id, string name, string email, string phone, string tin, DateTime birthDate) : base(id) // Inicializa a propriedade Id na classe base (Entity)
        {
            Name = name;
            Email = email;
            Phone = phone;
            TIN = tin;
            BirthDate = birthDate;
        }

        /// <summary>
        /// Retorna uma descrição textual do cliente.
        /// Sobrescreve o método abstrato GetDescription() da classe base Entity.
        /// </summary>
        /// <returns>Descrição básica contendo o nome e email do cliente.</returns>
        public override string GetDescription()
        {
            return $"Client: {Name}, Email: {Email}";
        }
    }
}
