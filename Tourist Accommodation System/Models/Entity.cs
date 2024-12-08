namespace Tourist_Accommodation_System.Models
{
    /// <summary>
    /// Classe base para entidades com identificador único.
    /// </summary>
    public abstract class Entity
    {
        // Propriedade de identificação única
        public int Id { get; set; }

        /// <summary>
        /// Construtor padrão para inicializações padrão ou deserialização.
        /// </summary>
        public Entity() { }

        /// <summary>
        /// Construtor que aceita um ID.
        /// </summary>
        /// <param name="id">Identificador único da entidade.</param>
        public Entity(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Método abstrato para obter uma descrição textual da entidade.
        /// Deve ser implementado pelas classes derivadas.
        /// </summary>
        /// <returns>Descrição textual da entidade.</returns>
        public abstract string GetDescription();
    }
}
