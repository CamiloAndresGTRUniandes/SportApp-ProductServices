namespace SportApp.ProductsServices.Domain.Training.Enums ;
using Common;

    public class SportLevel(int id, string name) : Enumeration(id, name)
    {
        public static readonly SportLevel Basic = new(1, nameof(Basic));
        public static readonly SportLevel Intermediate = new(1, nameof(Intermediate));
        public static readonly SportLevel Advanced = new(1, nameof(Advanced));
    }
