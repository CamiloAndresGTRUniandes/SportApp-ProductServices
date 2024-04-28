namespace SportApp.ProductsServices.Domain.Common.Enums ;

    public class SportLevel(int id, string name) : Enumeration(id, name)
    {
        public static readonly SportLevel Basico = new(1, nameof(Basico));
        public static readonly SportLevel Intermedio = new(2, nameof(Intermedio));
        public static readonly SportLevel Avanzado = new(3, nameof(Avanzado));
    }
