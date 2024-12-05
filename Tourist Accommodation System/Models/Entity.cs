namespace Tourist_Accommodation_System.Models


{
    public abstract class Entity
    {
        public int Id { get; set; }  // Identificador único para cada entidade

        // Método abstrato para descrever a entidade, implementado por subclasses
        public abstract string GetDescription();

    }
}
